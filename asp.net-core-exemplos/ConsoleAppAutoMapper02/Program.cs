using System;

namespace ConsoleAppAutoMapper02
{
    class Program
    {
        static void Main(string[] args)
        {
            var cliente = new Cliente()
            {
                Id = 1,
                Nome = "Carlos",
                Sobrenome = "Silva",
                DataNascimento = new DateTime(1980, 03, 12),
                Renda = 4012.04
            };

            //var clienteViewModel = new ClienteListViewModel()
            //{
            //    Id = cliente.Id,
            //    Nome = cliente.Nome,
            //    Sobrenome = cliente.Sobrenome,
            //    DataNascimento = cliente.DataNascimento
            //};

            var configuration = new AutoMapper.MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Cliente, ClienteListViewModel>();
                cfg.CreateMap<ClienteListViewModel, Cliente>();
            });
            var mapper = configuration.CreateMapper();
            var clienteViewModel = mapper.Map<ClienteListViewModel>(cliente);

            Console.WriteLine(clienteViewModel);
            Console.ReadLine();
        }
    }

    public class Cliente
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime DataNascimento { get; set; }
        public double Renda { get; set; }

        public override string ToString()
            => $"{Id} - {Nome} - {Sobrenome} - {DataNascimento} - {Renda}";
    }

    public class ClienteListViewModel
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime DataNascimento { get; set; }

        public override string ToString()
            => $"{Id} - {Nome} - {Sobrenome} - {DataNascimento}";
    }
}
