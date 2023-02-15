using System;

namespace ConsoleAppAutoMapper05
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
                cfg.AddMaps(typeof(Program).Assembly); // carrega automaticamente todos profiles app
            });
            var mapper = configuration.CreateMapper();
            var clienteViewModel = mapper.Map<ClienteListViewModel>(cliente);

            Console.WriteLine(clienteViewModel);
            Console.ReadLine();
        }
    }

    public class ClienteProfile : AutoMapper.Profile
    {
        public ClienteProfile()
        {
            CreateMap<Cliente, ClienteListViewModel>()
                .ForMember(dst => dst.NomeCompleto, map => map.MapFrom(src => $"{src.Nome} {src.Sobrenome}"))
                .ForMember(dst => dst.DataNasc, map => map.MapFrom(src => src.DataNascimento));     
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
        public string NomeCompleto { get; set; }
        public DateTime DataNasc { get; set; }

        public override string ToString()
            => $"{Id} - {NomeCompleto} - {DataNasc}";
    }
}
