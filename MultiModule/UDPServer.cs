using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;


namespace MHealthKiosk.MultiModule
{
    public delegate void NewPacketEvent(byte[] data);
    public delegate void EndNIBPNotice();
    public delegate void StatusReport(int moduleState, int currentPatientMode, int cycleMode, int errorState, int systol, int diastol, int mean, int pulseRate);
    public delegate void RTCP(int pressure, int errorCode, int stateCode);
    public delegate void SignalData(int data, bool snsd, bool snsa);
    public delegate void SignalInfo(int hr, int spo, bool snsd, bool snsa);

    class CustomUDPServer
    {
        IPEndPoint ipep;
        UdpClient clientSock;
        int mPort;
        Boolean mIsStarted;
        public event NewPacketEvent newPacketEvent;
        System.Threading.Thread mListenerThread;
        public CustomUDPServer(int port)
        {
            mPort = port;
            ipep = new IPEndPoint(IPAddress.Any, port);
            clientSock = new UdpClient(ipep);
            mListenerThread = new System.Threading.Thread(new System.Threading.ThreadStart(ListenToNetHandler));
            mIsStarted = false;
        }

        public void StartServer()
        {
            try
            {
                mListenerThread.Start();
                mIsStarted = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void StopServer()
        {
            try
            {
                mIsStarted = false;
                clientSock.Close();
                mListenerThread.Abort();
                //mListenerThread.Join();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void ListenToNetHandler()
        {
            IPEndPoint sender = new IPEndPoint(IPAddress.Any, 0);
            while (true)
            {
                try
                {
                    while (mIsStarted == true)
                    {
                        byte[] data = new byte[1024];
                        data = clientSock.Receive(ref sender);
                        newPacketEvent(data);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

    }


    class NetworkUtility
    {
        public static void SendUDPPacket(byte[] data, String dest, int port)
        {
            try
            {
                Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Dgram,
    ProtocolType.Udp);

                IPAddress serverAddr = IPAddress.Parse(dest);

                IPEndPoint endPoint = new IPEndPoint(serverAddr, port);


                sock.SendTo(data, endPoint);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

    public class SPO2Tools
    {
        private CustomUDPServer mUDPServer;
        public event SignalData mSignalDataEvent;
        public event SignalInfo mSignalInfoEvent;
        private int packetNumber = -10;
        private String mHRMSB;
        private String mHRLSB;
        private int spo2 = 0;
        private int rr = 0;
        private int lastII = -1;
        private bool snsd, snsa;
        private static bool IS_RUN_SYNKER = false;
        private Queue<QueueData> queue = new Queue<QueueData>();
        private Thread mSyncherThread;


        public SPO2Tools()
        {
            mUDPServer = new CustomUDPServer(7111);
            mUDPServer.newPacketEvent += new NewPacketEvent(mUDPServer_newPacketEvent);
            mSyncherThread = new Thread(new ThreadStart(mSyncerRunnable));
            IS_RUN_SYNKER = true;
        }

        void mUDPServer_newPacketEvent(byte[] data)
        {
            ParseSPO2Packet(data);
        }

        public void StopSPO2()
        {
            mUDPServer.StopServer();
            IS_RUN_SYNKER = false;
            mSyncherThread.Abort();
        }

        public void StartSPO2()
        {
            mUDPServer.StartServer();
            IS_RUN_SYNKER = true;
            mSyncherThread.Start();
        }

        private class QueueData
        {
            public int Data;
            public bool SNSD;
            public bool SNSA;
        }

        bool isSet(byte value, int bit)
        {
            return (value & (1 << bit)) != 0;
        }

        public static string hexEncode(byte[] ba)
        {
            string hex = BitConverter.ToString(ba);
            return hex.Replace("-", "");
        }

        private static int ParseHexString(string hexNumber)
        {
            hexNumber = hexNumber.Replace("x", string.Empty);
            int result = 0;
            int.TryParse(hexNumber, System.Globalization.NumberStyles.HexNumber, null, out result);
            return result;
        }

        private void mSyncerRunnable()
        {
            while (IS_RUN_SYNKER)
            {
                try
                {
                    QueueData data = takeData();
                    if (data != null)
                    {
                        mSignalDataEvent(data.Data, data.SNSA, data.SNSD);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    try
                    {
                        Thread.Sleep(5);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }
        }



        public void ParseSPO2Packet(byte[] client)
        {
            try
            {
                byte[] rData2 = client;
                int[] signalData = new int[25];
                bool[] checkSums = new bool[25];
                bool hasSpo2 = false;
                bool hasRR = false;
                for (int ii = 0; ii < 125; ii += 5)
                {
                    byte[] rData = new byte[5];
                    Array.Copy(rData2, ii, rData, 0, 5);
                    short sum = 0;
                    for (int i = 0; i < 4; i++)
                    {
                        sum += rData[i];
                    }
                    checkSums[ii / 5] = (sum == rData[4]);
                }



                for (int ii = 0; ii < 125; ii += 5)
                {
                    byte[] rData = new byte[5];
                    Array.Copy(rData2, ii, rData, 0, 5);
                    bool SNSD = isSet(rData[1], 6);
                    bool ARTF = isSet(rData[1], 5);
                    bool OOT = isSet(rData[1], 4);
                    bool SNSA = isSet(rData[1], 3);
                    bool RPRF = isSet(rData[1], 2);
                    bool GPRF = isSet(rData[1], 1);
                    bool SYNC = isSet(rData[1], 0);
                    bool YPRF = RPRF & GPRF;
                    if (SYNC == true)
                    {
                        packetNumber = 0;
                    }

                    if (packetNumber >= 0)
                    {

                        short sum = 0;
                        for (int i = 0; i < 4; i++)
                        {
                            sum += rData[i];
                        }

                        snsd = SNSD;
                        snsa = SNSA;
                        QueueData data = new QueueData();
                        int f = ParseHexString((hexEncode(new byte[] { rData[2] })));
                        data.Data = f;
                        data.SNSA = SNSA;
                        data.SNSD = SNSD;
                        addData(data);


                        packetNumber++;

                        if (packetNumber == 21)
                        {
                            mHRMSB = hexEncode(new byte[] { rData[3] });
                            lastII = packetNumber;
                        }
                        if (packetNumber == 22)
                        {
                            mHRLSB = hexEncode(new byte[] { rData[3] });
                            if (lastII + 1 == packetNumber)
                            {
                                rr = ParseHexString(mHRLSB + mHRMSB);
                                hasRR = true;
                            }
                        }
                        if (packetNumber == 16 )
                        {
                            spo2 = ParseHexString((hexEncode(new byte[] { rData[3] })));
                            hasSpo2 = true;
                        }
                    }
                }

                if (hasSpo2 && hasRR)
                {
                    mSignalInfoEvent(rr, spo2, snsd, snsa);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void addData(QueueData data)
        {
            if (!IS_RUN_SYNKER)
            {
                queue.Clear();
                return;
            }
            try
            {
                //while(queue.size()>= MAX_QUEUE_SIZE && IS_RUN_SYNKER) wait(); //wait() will temporarily release lock
                queue.Enqueue(data);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private QueueData takeData()
        {
            try
            {
                if (IS_RUN_SYNKER)
                {
                    QueueData poll = null;
                    if (IS_RUN_SYNKER)
                    {
                        poll = queue.Dequeue();
                    }
                    return poll;
                }
                else return null;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

    }


    public class NIBPTools
    {
        private CustomUDPServer mUDPServer;
        public event EndNIBPNotice NIBPEndNoticeEvent;
        public event RTCP RTCPEvent;
        public event StatusReport StatusReportEvent;

        public NIBPTools()
        {
            mUDPServer = new CustomUDPServer(7105);
            mUDPServer.newPacketEvent += new NewPacketEvent(mUDPServer_newPacketEvent);
        }

        public void StopNIBP()
        {
            mUDPServer.StopServer();
        }

        public void StartNIBP()
        {
            mUDPServer.StartServer();
        }

        void mUDPServer_newPacketEvent(byte[] data)
        {
            receivedNewPacket(data);
        }

        private byte[] CleanPacket(byte[] packet)
        {
            try
            {
                short startIndex = 0, endIndex = 0;
                for (int i = 0; i < packet.Length; i++)
                {
                    if (packet[i] == 0x02)
                    {
                        startIndex = (short)i;
                    }
                    else if (packet[i] == 0x03)
                    {
                        endIndex = (short)i;
                        break;
                    }
                }
                byte[] result = new byte[endIndex - startIndex + 1];
                for (short i = startIndex; i <= endIndex; i++)
                {
                    result[i - startIndex] = packet[i];
                }
                return result;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public void receivedNewPacket(byte[] client)
        {
            byte[] packet = CleanPacket(client);
            if (packet != null)
            {
                try
                {
                    if (true)
                    {
                        if (packet.Length == 9)
                        {
                            char a = (char)packet[1];
                            char b = (char)packet[2];
                            char c = (char)packet[3];
                            String sPressure = new String(new char[] { a,
									b, c });
                            int pressure = int.Parse(sPressure);
                            char error = (char)packet[5];
                            int errorCode = int.Parse("" + error);
                            char state = (char)packet[7];
                            int stateCode = int.Parse("" + state);
                            RTCPEvent((int)pressure, (int)errorCode, (int)stateCode);
                        }
                        else if (packet.Length == 5)
                        {
                            char a = (char)packet[1];
                            char b = (char)packet[2];
                            char c = (char)packet[3];
                            if (a == '9' && b == '9' && c == '9')
                            {
                                NIBPEndNoticeEvent();
                            }
                        }
                        else if (packet.Length == 41)
                        {
                            char ms = (char)packet[2];
                            char cpm = (char)packet[5];
                            char cm1 = (char)packet[8];
                            char cm2 = (char)packet[9];
                            char es1 = (char)packet[12];
                            char es2 = (char)packet[13];
                            char sys1 = (char)packet[16];
                            char sys2 = (char)packet[17];
                            char sys3 = (char)packet[18];
                            char dia1 = (char)packet[19];
                            char dia2 = (char)packet[20];
                            char dia3 = (char)packet[21];
                            char mean1 = (char)packet[22];
                            char mean2 = (char)packet[23];
                            char mean3 = (char)packet[24];
                            char pulse1 = (char)packet[27];
                            char pulse2 = (char)packet[28];
                            char pulse3 = (char)packet[29];
                            int moduleState = (int)int.Parse("" + (ms));
                            int currentPatientMode = (int)int.Parse
                            ("" + (cpm));
                            int cycleMode = (int)int.Parse(new String
                                    (new char[] { cm1, cm2 }));
                            int errorState = (int)int.Parse(new String
                                    (new char[] { es1, es2 }));
                            int systol = 0;
                            if (sys1 != '-')
                                systol = (int)int.Parse
                                (new String(new char[] {
										sys1, sys2, sys3 }));
                            int diastol = 0;
                            if (dia1 != '-')
                                diastol = (int)int.Parse
                                (new String(new char[] {
										dia1, dia2, dia3 }));
                            int mean = 0;
                            if (mean1 != '-')
                                mean = (int)int.Parse(new String
                                        (new char[] { mean1, mean2,
												mean3 }));
                            int pulseRate = 0;
                            if (pulse1 != '-')
                                pulseRate = (int)int.Parse(new String
                                        (new char[] { pulse1, pulse2,
												pulse3 }));
                            StatusReportEvent(
                                    moduleState, currentPatientMode, cycleMode,
                                    errorState, systol, diastol, mean,
                                    pulseRate);

                        }
                        else
                        {
                            Console.WriteLine("**** bad packet");
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }


        public static void StartNIBPMeasurement(String deviceAddress)
        {
            new System.Threading.Thread(new System.Threading.ThreadStart(() =>
            {
                byte[] packet = new byte[8];
                packet[0] = 0x02;
                packet[1] = (byte)'0';
                packet[2] = (byte)'1';
                packet[3] = (byte)';';
                packet[4] = (byte)';';
                packet[5] = (byte)'D';
                packet[6] = (byte)'7';
                packet[7] = 0x03;
                NetworkUtility.SendUDPPacket(packet, deviceAddress, 7105);
            })).Start();
        }

        public static void StopNIBPMeasurement(String deviceAddress)
        {
            new System.Threading.Thread(new System.Threading.ThreadStart(() =>
            {
                byte[] packet = new byte[1];
                packet[0] = 0x58;
                NetworkUtility.SendUDPPacket(packet, deviceAddress, 7105);
            })).Start();
        }
    }
}
