using aadea.Vistas;

namespace aadea.Extras;

public static class HelpMSG
{
    /// <summary>
    /// Mostar notificacion
    /// </summary>
    /// <param name="form"></param>
    /// <param name="mensaje">string</param>
    /// <param name="tipo">1 Succes. 2 Info. 3 Error</param>
    public static void MostrarNotificacion(this Form form, string mensaje, int tipo)
    {
        Notificaciones notificacion = new Notificaciones(mensaje, tipo);

        int x = form.Right - notificacion.Width;
        int y = form.Bottom - notificacion.Height;
        notificacion.StartPosition = FormStartPosition.Manual;
        notificacion.Location = new Point(x, y);

        notificacion.Show(form);
    }
}