String IPToString(IPAddress ip)
{
    String str = "";
    for (int i = 0; i < 4; i++)
        str += i  ? "." + String(ip[i]) : String(ip[i]);
    return str;
}
