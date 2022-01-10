using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using WCFService_2Way_20190140129;

namespace ClientChatApp_20190140129_RafifFuaddoshofha
{
    public class ClientCallBack : ServiceReference1.IServiceCallback
    {
        public void gabung(string username)
        {
            throw new NotImplementedException();
        }

        public Task gabungAsync(string username)
        {
            throw new NotImplementedException();
        }

        public string GetData(int value)
        {
            throw new NotImplementedException();
        }

        public Task<string> GetDataAsync(int value)
        {
            throw new NotImplementedException();
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            throw new NotImplementedException();
        }

        public Task<CompositeType> GetDataUsingDataContractAsync(CompositeType composite)
        {
            throw new NotImplementedException();
        }

        public void kirimPesan(string pesan)
        {
            throw new NotImplementedException();
        }

        public Task kirimPesanAsync(string pesan)
        {
            throw new NotImplementedException();
        }

        public void pesanKirim(string user, string pesan)
        {
            Console.WriteLine("{0}: {1}", user, pesan);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            InstanceContext context = new InstanceContext(new ClientCallBack());
            ServiceReference1.ServiceCallbackClient server = new ServiceReference1.ServiceCallbackClient(context);

            Console.WriteLine("Enter Username");
            string nama = Console.ReadLine();
            server.gabung(nama);

            Console.WriteLine("Kirim Pesan : ");
            string pesan = Console.ReadLine();

            while (true)
            {
                if (!string.IsNullOrEmpty(pesan)) server.kirimPesan(pesan);
                Console.WriteLine("Kirim Pesan");
                pesan = Console.ReadLine();
            }

        }
    }
}
