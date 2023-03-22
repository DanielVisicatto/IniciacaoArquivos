
// path = @"C:\\Users\\" + Environment.UserName;

string path = @"C:\\Users\\" + Environment.UserName; // Esta linha deixa o local de gravação dos arquivos
//genérico, para que abra grave e leia de qualquer outro computador que execute este código.

Console.Write("Informe o nome do aquivo: ");
string filename = @"\\" + Console.ReadLine();// adiciona o nome do arquivo setado pelo usuário depois de uma \
string fullpath = string.Concat(path, filename);// concatena a entrada do usuário com nosso caminho formando o local completo.

bool SaveFile(Contact? c)
{
    try
    {
        StreamWriter sw = new(fullpath);
        sw.WriteLine(c);
        sw.Close();
    }
    catch(Exception e)
    {
        Console.WriteLine("Exception: " + e.Message);
        return false;
    }
    finally
    {
        Console.WriteLine("Executando bloco de comandos");
        Console.WriteLine("FIM DA GRAVAÇÃO");
    }
    return true;
}
bool OpenFile()
{
    try
    {
        StreamReader sr = new(fullpath);
        var line = sr.ReadLine;
        while (line != null)
        {
            Console.WriteLine(line);
            sr.Close();
        }
    }
    catch (Exception e)
    {
        Console.WriteLine("Exception: "+ e.Message);
        return false;
    }
    finally
    {
        Console.WriteLine("Fim da leitura do arquivo");
        Console.ReadLine();
    }
    return true;
}