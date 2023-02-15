using System;

namespace ConsoleAppAutoMapper03
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

            var configuration = new AutoMapper.MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new ClienteProfile());
                //OU cfg.AddProfile<ClienteProfile>();
            });

            AutoMapper.IMapper mapper = configuration.CreateMapper();
            var clienteListViewModel = mapper.Map<ClienteListViewModel>(cliente);

            Console.WriteLine(clienteListViewModel);
        }
    }

    public class ClienteProfile : AutoMapper.Profile
    {
        public ClienteProfile()
        {
            //CreateMap<Cliente, ClienteListViewModel>(); //reverse map faz isto
            CreateMap<ClienteListViewModel, Cliente>().ReverseMap();
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
