using System;
using RabbitMQ.Client;
using System.Text;
using System.Threading.Tasks;

class Sender
{
    public static async Task<int> Main()
    {
        var factory = new ConnectionFactory
        {
            HostName = "stateful-rabbitmq.demo",
            UserName = "user",
            Password = "password"
        };

        using (var connection = factory.CreateConnection())
        using (var channel = connection.CreateModel())
        {
            channel.QueueDeclare(queue: "hello", durable: false, exclusive: false, autoDelete: false, arguments: null);

            int i = 0;
            while (true)
            {
                string message = $"Hello World! {i}";
                var body = Encoding.UTF8.GetBytes(message);

                channel.BasicPublish(exchange: "", routingKey: "hello", basicProperties: null, body: body);
                Console.WriteLine(" [x] Sent {0} {1}", message, i++);

                await Task.Delay(1000);
            }
        }
    }
}