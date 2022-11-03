namespace ConsoleAppEventsDelegates
{
    internal class ArquivoConverter
    {
        public delegate void ArquivoConvertidoEventHandler(
            object source,
            EventArgs args);

        public event ArquivoConvertidoEventHandler ArquivoConvertido;

        public void Converter(Arquivo arquivo)
        {
            Thread.Sleep(5000);
            this.ArquivoFinalizado();
        }

        public void ArquivoFinalizado()
        {
            if (ArquivoFinalizado != null)
            {
                ArquivoConvertido(this, EventArgs.Empty);
            }
        }
    }
}
