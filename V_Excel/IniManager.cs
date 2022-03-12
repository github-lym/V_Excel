using System.Runtime.InteropServices;
using System.Text;

internal class IniManager
{
    private string filePath;
    private StringBuilder lpReturnedString;
    private int bufferSize;

    [DllImport("kernel32")]
    public static extern bool WritePrivateProfileString(byte[] section, byte[] key, byte[] val, string filePath);

    [DllImport("kernel32")]
    public static extern int GetPrivateProfileString(byte[] section, byte[] key, byte[] def, byte[] retVal, int size, string filePath);

    public IniManager(string iniPath)
    {
        filePath = iniPath;
        bufferSize = int.MaxValue / 10;
        lpReturnedString = new StringBuilder(bufferSize);        
    }

    //与ini交互必须统一编码格式
    private static byte[] getBytes(string s, string encodingName)
    {
        return null == s ? null : Encoding.GetEncoding(encodingName).GetBytes(s);
    }

    public string ReadIniFile(string section, string key, string def, string encodingName = "utf-8")
    {
        byte[] buffer = new byte[bufferSize];
        int count = GetPrivateProfileString(getBytes(section, encodingName), getBytes(key, encodingName), getBytes(def, encodingName), buffer, bufferSize, filePath);
        return Encoding.GetEncoding(encodingName).GetString(buffer, 0, count).Trim();
    }

    public bool WriteIniFile(string section, string key, string value, string encodingName = "utf-8")
    {
        return WritePrivateProfileString(getBytes(section, encodingName), getBytes(key, encodingName), getBytes(value, encodingName), filePath);
    }
}