using Microsoft.Data.SqlClient;

namespace ScreenSound.Banco;

public class Connection
{
    private string connectionString = "Server=localhost,1433;Database=ScreenSound;User ID=sa;Password=MyPassword123#";

    public SqlConnection ObterConnection()
    {
        return new SqlConnection(connectionString);
    }
}