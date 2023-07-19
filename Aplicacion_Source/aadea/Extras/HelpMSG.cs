using aadea.Vistas;

namespace aadea.Extras;

public static class HelpMSG
{
    public static void MostrarNotificacion(this Form form, string mensaje, Color color, int tipo)
    {
        Notificaciones notificacion = new Notificaciones(mensaje, color, tipo);

        int x = form.Right - notificacion.Width;
        int y = form.Bottom - notificacion.Height;
        notificacion.StartPosition = FormStartPosition.Manual;
        notificacion.Location = new Point(x, y);

        notificacion.Show(form);
    }
}