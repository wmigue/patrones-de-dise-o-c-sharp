namespace restaurant.STATE
{
    public class Mesa
    {
        public IEstado EstadoActual { get; set; }
        public IEstado EstadoAbierta { get; set; }
        public IEstado EstadoCerrada { get; set; }

        public double cuenta = 0.00;

        public Mesa()
        {
            EstadoAbierta = new EstadoAbierta(this); //le paso el objeto entero con this.
            EstadoCerrada = new EstadoCerrada(this);
            EstadoActual = EstadoAbierta;
        }
        public void OrdenarMesa(double precio)
        {
            EstadoActual.Ordenar(precio);
        }
        public void PagarMesa(int medioPago)
        {
            EstadoActual.Pagar(medioPago);
        }
        public void ReabrirMesa()
        {
            EstadoActual.Reabrir();
        }
        public double GetCuenta()
        {
            return cuenta;
        }
        //public void changeestado()
        //{
        //    if (estadoactual == estadoabierta)

        //        estadoactual = estadocerrada;
        //    else
        //        estadoactual = estadoabierta;
        //}

    }
}
