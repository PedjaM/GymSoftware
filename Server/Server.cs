using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server
{
    public class Server
    {
        Socket soket;
        ThreadStart ts;
        public bool PokreniServer()
        {
            try
            {
                soket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPEndPoint ep = new IPEndPoint(IPAddress.Any, 20000);
                soket.Bind(ep);
                 ts = Osluskuj;
                new Thread(ts).Start();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool ZaustaviServer()
        {
            try
            {
                soket.Close();
                
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public void Osluskuj()
        {
            try
            {
                bool x = true;
                while(true)
                {
                   
          
                    try
                    {
                        soket.Listen(8);
                        Socket klijent = soket.Accept();
                        NetworkStream tok = new NetworkStream(klijent);
                        new NitKlijenta(tok);
                    }catch(Exception)
                    {
                        x = false;
                    }
                       
  

                 
                }
                
            }
            catch (Exception)
            {
                throw;
                
            }
        }
    }
}
