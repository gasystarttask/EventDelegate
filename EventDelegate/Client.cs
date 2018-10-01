using System;

namespace EventDelegate
{
    public class Client
    {
        public Client()
        {
            IPublisher<int> intPublisher = new Publisher<int>();
            var intSublisher1 = new Subscriber<int>(intPublisher);
            intSublisher1.Publisher.DataPublisher += publisher_DataPublisher1;

            var intSublisher2 = new Subscriber<int>(intPublisher);
            intSublisher2.Publisher.DataPublisher += publisher_DataPublisher2;

            intPublisher.PublishData(10);
        }

        void publisher_DataPublisher1(object sender, MessageArgument<int> e)
        {
            Console.WriteLine("Subscriber 1 : " + e.Message);
        }


        void publisher_DataPublisher2(object sender, MessageArgument<int> e)
        {
            Console.WriteLine("Subscriber 2 : " + e.Message);
        }
    }
}
