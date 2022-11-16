using ByteBank.Core.Model;
using ByteBank.Core.Repository;
using ByteBank.Core.Service;
using ByteBank.View.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ByteBank.View
{
    public partial class MainWindow : Window
    {
        private readonly ContaClienteRepository r_Repositorio;
        private readonly ContaClienteService r_Servico;
        private CancellationTokenSource _cts;

        public MainWindow()
        {
            InitializeComponent();

            r_Repositorio = new ContaClienteRepository();
            r_Servico = new ContaClienteService();
        }

        //private async void BtnProcessar_Click(object sender, RoutedEventArgs e)
        //{
        //    var taskSchedulerUI = TaskScheduler.FromCurrentSynchronizationContext();
        //    BtnProcessar.IsEnabled = false;

        //    var contas = r_Repositorio.GetContaClientes();

        //    var contasQuantidadePorThread = contas.Count() / 4;

        //    var contasParte1 = contas.Take(contasQuantidadePorThread);
        //    var contasParte2 = contas.Skip(contasQuantidadePorThread).Take(contasQuantidadePorThread);
        //    var contasParte3 = contas.Skip(contasQuantidadePorThread * 2).Take(contasQuantidadePorThread);
        //    var contasParte4 = contas.Skip(contasQuantidadePorThread * 3);

        //    var resultado = new List<string>();

        //    AtualizarView(new List<string>(), TimeSpan.Zero);

        //    var inicio = DateTime.Now;

        //    //foreach (var conta in contas)
        //    //{
        //    //    var resultadoConta = r_Servico.ConsolidarMovimentacao(conta);
        //    //    resultado.Add(resultadoConta);
        //    //}

        //    //Thread threadParte1 = new Thread(() =>
        //    //{
        //    //    foreach (var conta in contasParte1)
        //    //    {
        //    //        var resultadoProcessamento = r_Servico.ConsolidarMovimentacao(conta);
        //    //        resultado.Add(resultadoProcessamento);
        //    //    }
        //    //});

        //    //Thread threadParte2 = new Thread(() =>
        //    //{
        //    //    foreach (var conta in contasParte2)
        //    //    {
        //    //        var resultadoProcessamento = r_Servico.ConsolidarMovimentacao(conta);
        //    //        resultado.Add(resultadoProcessamento);
        //    //    }
        //    //});

        //    //Thread threadParte3 = new Thread(() =>
        //    //{
        //    //    foreach (var conta in contasParte3)
        //    //    {
        //    //        var resultadoProcessamento = r_Servico.ConsolidarMovimentacao(conta);
        //    //        resultado.Add(resultadoProcessamento);
        //    //    }
        //    //});

        //    //Thread threadParte4 = new Thread(() =>
        //    //{
        //    //    foreach (var conta in contasParte4)
        //    //    {
        //    //        var resultadoProcessamento = r_Servico.ConsolidarMovimentacao(conta);
        //    //        resultado.Add(resultadoProcessamento);
        //    //    }
        //    //});

        //    //threadParte1.Start();
        //    //threadParte2.Start();
        //    //threadParte3.Start();
        //    //threadParte4.Start();

        //    //while (threadParte1.IsAlive || threadParte2.IsAlive || threadParte3.IsAlive || threadParte4.IsAlive)
        //    //{
        //    //    Thread.Sleep(250);
        //    //}

        //    var contasTarefas = contas.Select(conta =>
        //    {
        //        return Task.Factory.StartNew(() =>
        //        {
        //            //var resultadoConta = r_Servico.ConsolidarMovimentacao(conta);
        //            //resultado.Add(resultadoConta);
        //            return r_Servico.ConsolidarMovimentacao(conta);
        //        });
        //    }).ToArray();

        //    //Task.WaitAll(contasTarefas);


        //    //Task.WhenAll(contasTarefas)
        //    //    .ContinueWith(task =>
        //    //    {
        //    //        var fim = DateTime.Now;
        //    //        AtualizarView(resultado, fim - inicio);
        //    //    }, taskSchedulerUI)
        //    //    .ContinueWith(task =>
        //    //    {
        //    //        BtnProcessar.IsEnabled = true;
        //    //    }, taskSchedulerUI);

        //    // sem await
        //    ConsolidarContas(contas).ContinueWith(task =>
        //    {
        //        var fim = DateTime.Now;
        //        resultado = task.Result;
        //        AtualizarView(resultado, fim - inicio);
        //    }, taskSchedulerUI)
        //        .ContinueWith(task =>
        //        {
        //            BtnProcessar.IsEnabled = true;
        //        }, taskSchedulerUI);

        //    var fim = DateTime.Now;
        //    AtualizarView(resultado, fim - inicio);
        //    BtnProcessar.IsEnabled = true;
        //}

        private async void BtnProcessar_Click(object sender, RoutedEventArgs e)
        {
            BtnProcessar.IsEnabled = false;

            var contas = r_Repositorio.GetContaClientes();

            AtualizarView(new List<string>(), TimeSpan.Zero);

            var inicio = DateTime.Now;

            var resultado = await ConsolidarContas(contas);

            var fim = DateTime.Now;
            AtualizarView(resultado, fim - inicio);
            BtnProcessar.IsEnabled = true;
        }

        //private async void BtnProcessar_Click(object sender, RoutedEventArgs e)
        //{
        //    BtnProcessar.IsEnabled = false;

        //    _cts = new CancellationTokenSource();

        //    var contas = r_Repositorio.GetContaClientes();

        //    PgsProgresso.Maximum = contas.Count();

        //    LimparView();

        //    var inicio = DateTime.Now;

        //    BtnCancelar.IsEnabled = true;
        //    var progress = new Progress<String>(str =>
        //        PgsProgresso.Value++);

        //    try
        //    {
        //        var resultado = await ConsolidarContas(contas, progress, _cts.Token);

        //        var fim = DateTime.Now;
        //        AtualizarView(resultado, fim - inicio);
        //    }
        //    catch (OperationCanceledException)
        //    {
        //        TxtTempo.Text = "Operação cancelada pelo usuário";
        //    } 
        //    finally
        //    {
        //        BtnProcessar.IsEnabled = true;
        //        BtnCancelar.IsEnabled = false;
        //    }
        //}

        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {
            BtnCancelar.IsEnabled = false;
            _cts.Cancel();
        }

        //private Task<List<string>> ConsolidarContas(IEnumerable<ContaCliente> contas)
        //{
        //    var resultado = new List<string>();
        //    var tasks = contas.Select(conta =>
        //    {
        //        return Task.Factory.StartNew(() =>
        //        {
        //            var contaResultado = r_Servico.ConsolidarMovimentacao(conta);
        //            resultado.Add(contaResultado);
        //        });
        //    });

        //    return Task.WhenAll(tasks).ContinueWith(t =>
        //    {
        //        return resultado;
        //    });
        //}

        private async Task<string[]> ConsolidarContas(IEnumerable<ContaCliente> contas)
        {
            var tasks = contas.Select(conta =>
                Task.Factory.StartNew(() => r_Servico.ConsolidarMovimentacao(conta))
            );

            var resultado = await Task.WhenAll(tasks);

            return resultado;
        }

        //private async Task<string[]> ConsolidarContas(IEnumerable<ContaCliente> contas, IProgress<string> reportadorDeProgresso, CancellationToken ct)
        //{
        //    var tasks = contas.Select(conta =>
        //        Task.Factory.StartNew(() =>
        //        {
        //            ct.ThrowIfCancellationRequested();

        //            var resultadoConsolidacao = r_Servico.ConsolidarMovimentacao(conta, ct);

        //            reportadorDeProgresso.Report(resultadoConsolidacao);

        //            ct.ThrowIfCancellationRequested();
        //            return resultadoConsolidacao;
        //        }, ct)
        //    );

        //    return await Task.WhenAll(tasks);
        //}

        private void LimparView()
        {
            LstResultados.ItemsSource = null;
            TxtTempo.Text = null;
            PgsProgresso.Value = 0;
        }

        private void AtualizarView(IEnumerable<String> result, TimeSpan elapsedTime)
        {
            var tempoDecorrido = $"{elapsedTime.Seconds}.{elapsedTime.Milliseconds} segundos!";
            var mensagem = $"Processamento de {result.Count()} clientes em {tempoDecorrido}";

            LstResultados.ItemsSource = result;
            TxtTempo.Text = mensagem;
        }
    }
}
