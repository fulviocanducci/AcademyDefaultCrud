using System.Windows.Forms;

namespace Academy.Forms
{
    internal static class Message
    {

        internal static void SuccessInsert()
        {
            MessageBox.Show("Dados inserido com êxito", "Operações", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        internal static void SuccessUpdate()
        {
            MessageBox.Show("Dados alterdo com êxito", "Operações", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        internal static void ErrorValidation(string errors)
        {
            MessageBox.Show(errors ?? "Errors encontrados.", "Validações", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
