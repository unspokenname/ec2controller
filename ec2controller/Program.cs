using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amazon;
using Amazon.EC2;
using Amazon.EC2.Model;

namespace ec2controller
{
    class Program
    {

        static int GetPianoKey(string note)
        {
            int key = -1;
            switch (note[0])
            {
                case 'A': key = 1; break;
                case 'B': key = 3; break;
                case 'C': key = 4; break;
                case 'D': key = 6; break;
                case 'E': key = 8; break;
                case 'F': key = 9; break;
                case 'G': key = 11; break;
            }
            if (note.Length == 2)
            {
                return key + 12 * (note[1] - '0');
            }
            if (note.Length == 3)
            {
                return key + 12 * (note[2] - '0') + (note[1] == 'b' ? -1 : 1);
            }
            throw new ApplicationException("Wrong note.");
        }

        static int GetNoteFrequency(string note)
        {
            return (int)(Math.Pow(1.05946309436, GetPianoKey(note) - 49) * 440);
        }

        static int GetTickDuration(int tempo)
        {
            return 60000 / tempo;
        }

        private static void jungkin()
        {
            int duration = GetTickDuration(120); // 120 bpm. duration for quarter note

            for (int i = 0; i < 2; i++)
            {
                Console.Beep(GetNoteFrequency("A3"), duration / 2); // eighth note ==> duration/2
                Console.Beep(GetNoteFrequency("B3"), duration / 2);
                Console.Beep(GetNoteFrequency("C3"), duration / 2);
                Console.Beep(GetNoteFrequency("D3"), duration / 2);

                Console.Beep(GetNoteFrequency("E3"), duration / 2);
                Console.Beep(GetNoteFrequency("C3"), duration / 2);
                Console.Beep(GetNoteFrequency("E3"), duration / 2);
                Task.Delay(duration / 2).Wait(); //  eighth rest ==> duration/2

                Console.Beep(GetNoteFrequency("D#3"), duration / 2);
                Console.Beep(GetNoteFrequency("B3"), duration / 2);
                Console.Beep(GetNoteFrequency("D#3"), duration / 2);
                Task.Delay(duration / 2).Wait();

                Console.Beep(GetNoteFrequency("D3"), duration / 2);
                Console.Beep(GetNoteFrequency("Bb3"), duration / 2);
                Console.Beep(GetNoteFrequency("D3"), duration / 2);
                Task.Delay(duration / 2).Wait();

                Console.Beep(GetNoteFrequency("A3"), duration / 2);
                Console.Beep(GetNoteFrequency("B3"), duration / 2);
                Console.Beep(GetNoteFrequency("C3"), duration / 2);
                Console.Beep(GetNoteFrequency("D3"), duration / 2);

                Console.Beep(GetNoteFrequency("E3"), duration / 2);
                Console.Beep(GetNoteFrequency("C3"), duration / 2);
                Console.Beep(GetNoteFrequency("E3"), duration / 2);
                Console.Beep(GetNoteFrequency("A4"), duration / 2);

                Console.Beep(GetNoteFrequency("G3"), duration / 2);
                Console.Beep(GetNoteFrequency("E3"), duration / 2);
                Console.Beep(GetNoteFrequency("C3"), duration / 2);
                Console.Beep(GetNoteFrequency("E3"), duration / 2);

                Console.Beep(GetNoteFrequency("G3"), duration * 2); // half note ==> duration*2
            }
        }
        public static void mariobro()
        {
            Console.Beep(480, 200);
            Console.Beep(1568, 200);
            Console.Beep(1568, 200);
            Console.Beep(1568, 200);
            Console.Beep(740, 200);
            Console.Beep(784, 200);
            Console.Beep(784, 200);
            Console.Beep(784, 200);
            Console.Beep(370, 200);
            Console.Beep(392, 200);
            Console.Beep(370, 200);
            Console.Beep(392, 200);
            Console.Beep(392, 400);
            Console.Beep(196, 400);
            Console.Beep(740, 200);
            Console.Beep(784, 200);
            Console.Beep(784, 200);
            Console.Beep(740, 200);
            Console.Beep(784, 200);
            Console.Beep(784, 200);
            Console.Beep(740, 200);
            Console.Beep(84, 200);
            Console.Beep(880, 200);
            Console.Beep(831, 200);
            Console.Beep(880, 200);
            Console.Beep(988, 400);
            Console.Beep(880, 200);
            Console.Beep(784, 200);
            Console.Beep(699, 200);
            Console.Beep(740, 200);
            Console.Beep(784, 200);
            Console.Beep(784, 200);
            Console.Beep(740, 200);
            Console.Beep(784, 200);
            Console.Beep(784, 200);
            Console.Beep(740, 200);
            Console.Beep(784, 200);
            Console.Beep(880, 200);
            Console.Beep(831, 200);
            Console.Beep(880, 200);
            Console.Beep(988, 400);
            System.Threading.Thread.Sleep(200);
            Console.Beep(1108, 10);
            Console.Beep(1174, 200);
            Console.Beep(1480, 10);
            Console.Beep(1568, 200);
            System.Threading.Thread.Sleep(200);
            Console.Beep(740, 200);
            Console.Beep(784, 200);
            Console.Beep(784, 200);
            Console.Beep(740, 200);
            Console.Beep(784, 200);
            Console.Beep(784, 200);
            Console.Beep(740, 200);
            Console.Beep(784, 200);
            Console.Beep(880, 200);
            Console.Beep(831, 200);
            Console.Beep(880, 200);
            Console.Beep(988, 400);
            Console.Beep(880, 200);
            Console.Beep(784, 200);
            Console.Beep(699, 200);
            Console.Beep(659, 200);
            Console.Beep(699, 200);
            Console.Beep(784, 200);
            Console.Beep(880, 400);
            Console.Beep(784, 200);
            Console.Beep(699, 200);
            Console.Beep(659, 200);
            Console.Beep(587, 200);
            Console.Beep(659, 200);
            Console.Beep(699, 200);
            Console.Beep(784, 400);
            Console.Beep(699, 200);
            Console.Beep(659, 200);
            Console.Beep(587, 200);
            Console.Beep(523, 200);
            Console.Beep(587, 200);
            Console.Beep(659, 200);
            Console.Beep(699, 400);
            Console.Beep(659, 200);
            Console.Beep(587, 200);
            Console.Beep(494, 200);
            Console.Beep(523, 200);
            System.Threading.Thread.Sleep(400);
            Console.Beep(349, 400);
            Console.Beep(392, 200);
            Console.Beep(330, 200);
            Console.Beep(523, 200);
            Console.Beep(494, 200);
            Console.Beep(466, 200);
            Console.Beep(440, 200);
            Console.Beep(494, 200);
            Console.Beep(523, 200);
            Console.Beep(880, 200);
            Console.Beep(494, 200);
            Console.Beep(880, 200);
            Console.Beep(1760, 200);
            Console.Beep(440, 200);
            Console.Beep(392, 200);
            Console.Beep(440, 200);
            Console.Beep(494, 200);
            Console.Beep(784, 200);
            Console.Beep(440, 200);
            Console.Beep(784, 200);
            Console.Beep(1568, 200);
            Console.Beep(392, 200);
            Console.Beep(349, 200);
            Console.Beep(392, 200);
            Console.Beep(440, 200);
            Console.Beep(699, 200);
            Console.Beep(415, 200);
            Console.Beep(699, 200);
            Console.Beep(1397, 200);
            Console.Beep(349, 200);
            Console.Beep(330, 200);
            Console.Beep(311, 200);
            Console.Beep(330, 200);
            Console.Beep(659, 200);
            Console.Beep(699, 400);
            Console.Beep(784, 400);
            Console.Beep(440, 200);
            Console.Beep(494, 200);
            Console.Beep(523, 200);
            Console.Beep(880, 200);
            Console.Beep(494, 200);
            Console.Beep(880, 200);
            Console.Beep(1760, 200);
            Console.Beep(440, 200);
            Console.Beep(392, 200);
            Console.Beep(440, 200);
            Console.Beep(494, 200);
            Console.Beep(784, 200);
            Console.Beep(440, 200);
            Console.Beep(784, 200);
            Console.Beep(1568, 200);
            Console.Beep(392, 200);
            Console.Beep(349, 200);
            Console.Beep(392, 200);
            Console.Beep(440, 200);
            Console.Beep(699, 200);
            Console.Beep(659, 200);
            Console.Beep(699, 200);
            Console.Beep(740, 200);
            Console.Beep(784, 200);
            Console.Beep(392, 200);
            Console.Beep(392, 200);
            Console.Beep(392, 200);
            Console.Beep(392, 200);
            Console.Beep(196, 200);
            Console.Beep(196, 200);
            Console.Beep(196, 200);
            Console.Beep(185, 200);
            Console.Beep(196, 200);
            Console.Beep(185, 200);
            Console.Beep(196, 200);
            Console.Beep(208, 200);
            Console.Beep(220, 200);
            Console.Beep(233, 200);
            Console.Beep(247, 200);
        }

        //private static IAmazonEC2 ec2;
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("WELCOME!".PadRight(Console.WindowWidth - 1));
            Console.WriteLine();
            //jungkin();
            Console.WriteLine("To start, please input your IAM access key and secret key...");
            Console.Write("Access key:");
            string acky=Console.ReadLine();
            while(string.IsNullOrEmpty(acky))
            {
                Console.WriteLine("Key cannot be blank!");
                Console.Write("Access key:");
                acky = "AKIAJMUWKB7BA755PFZA";// Console.ReadLine();
            }
            Console.Write("Secret key:");
            string scky = Console.ReadLine();
            while (string.IsNullOrEmpty(scky))
            {
                Console.WriteLine("Key cannot be blank!");
                Console.Write("Secret key:");
                scky = "dXLAt7iJ90Dh6lUpdsNqSytVshfi2mSGuhL6ZK6o";// Console.ReadLine();
            }
            Console.WriteLine("Please select 1,2 or 3 as per Region:");
            Console.WriteLine("1.us-east-1");
            Console.WriteLine("2.us-east-2");
            Console.WriteLine("3.us-gov");
            Console.Write("Region#:");    
            RegionEndpoint rep = getRegs(Console.ReadLine());
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Attempting to connect...");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            try
            {
                IAmazonEC2 ec2 = new AmazonEC2Client(acky, scky, rep);
                DescribeInstancesRequest ec2Request = new DescribeInstancesRequest();
                DescribeInstancesResponse ec2Response = ec2.DescribeInstances(ec2Request);
                int numInstances = 0;
                numInstances = ec2Response.Reservations.Count;
                Console.WriteLine(string.Format("You have {0} Amazon EC2 instance(s) running in the {1} region.", numInstances, rep.DisplayName));
                int i = numInstances;

                Console.WriteLine("SERIAL".PadRight(8) + "+++++" + "TAG NAME".PadRight(20) + "+++++" + "INSTANCE ID".PadRight(20) + "+++++" + "PRIVATE IP".PadRight(20) + "+++++" + "STATE".PadRight(20));
                int num = 0;
                foreach (Reservation ri in ec2Response.Reservations)
                {
                    foreach (var instance in ri.Instances)
                    {
                        Console.WriteLine(num.ToString().PadRight(8) + "+++++" + instance.Tags[0].Key.PadRight(20)+"+++++"+ instance.InstanceId.PadRight(20) + "+++++" + instance.PrivateIpAddress.PadRight(20) + "+++++" + instance.State.Code.ToString().PadRight(20));
                        num++;
                        //foreach (var blockd in instance.BlockDeviceMappings)
                        //{
                        //    Console.Write("+++++"+blockd.Ebs.VolumeId+ "+++++"+ blockd.DeviceName);
                        //}
                    }
                }

                //This code will start your EC2 instance.

                //StartInstancesRequest startRequest = new StartInstancesRequest();
                //change instance id
                ///startRequest.InstanceIds.Add("i-4d2213bb");
                //ec2.StartInstances(startRequest);

                //This code will stop your EC2 instance.

                //StopInstancesRequest stopRequest = new StopInstancesRequest();
                //stopRequest.InstanceIds.Add("i-4d2213bb");
                //ec2.StopInstances(stopRequest);
            }
            catch (AmazonEC2Exception ex)
            {
                if (ex.ErrorCode != null && ex.ErrorCode.Equals("AuthFailure"))
                {
                    Console.WriteLine("The account you are using is not signed up for Amazon EC2.");
                }
                else
                {
                    Console.WriteLine("Caught Exception: " + ex.Message);
                }
            }
            Console.ReadLine();
            //mariobro();
            Console.ResetColor();
        }

        private static RegionEndpoint getRegs(string regi)
        {
            switch (regi)
            {
                case "us-east-1":
                    return RegionEndpoint.USEast1;
                case "us-east-2":
                    return RegionEndpoint.USEast2;
                case "us-gov":
                    return RegionEndpoint.USGovCloudWest1;
                default:
                    return RegionEndpoint.USEast1;
            }
        }
    }
}
