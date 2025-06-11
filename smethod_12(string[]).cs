// ns3.Class14
// Token: 0x060000A4 RID: 164 RVA: 0x00004904 File Offset: 0x00002B04
public static int smethod_12(string[] string_12)
{
	global::ns2.Class15 @class = new global::ns2.Class15();
	string text = global::ns3.Class14.smethod_1(global::System.Windows.Forms.Application.ExecutablePath);
	global::System.IntPtr hinstance = global::System.Runtime.InteropServices.Marshal.GetHINSTANCE(@class.GetType().Module);
	global::ns3.Class14.smethod_2(hinstance);
	if (global::ns3.Class14.int_11 != 0 && ((string_12.Length != 0 && string_12[0].CompareTo("-HOSTRUNAS") != 0) || string_12.Length == 0))
	{
		global::System.Diagnostics.Process process = new global::System.Diagnostics.Process();
		global::System.Security.SecureString secureString = new global::System.Security.SecureString();
		int num = 0;
		if (global::ns3.Class14.string_4.Contains("@"))
		{
			num = 1;
		}
		if (global::ns3.Class14.string_4.Contains("\\"))
		{
			num = 2;
		}
		foreach (char c in global::ns3.Class14.string_5.ToCharArray())
		{
			secureString.AppendChar(c);
		}
		secureString.MakeReadOnly();
		process.StartInfo.Password = secureString;
		if (num != 0)
		{
			char c2;
			if (num == 1)
			{
				c2 = '@';
			}
			else
			{
				c2 = '\\';
			}
			string[] array2 = global::ns3.Class14.string_4.Split(new char[] { c2 });
			if (num == 1)
			{
				process.StartInfo.UserName = array2[0];
				process.StartInfo.Domain = array2[1];
			}
			else
			{
				process.StartInfo.UserName = array2[1];
				process.StartInfo.Domain = array2[0];
			}
		}
		else
		{
			process.StartInfo.UserName = global::ns3.Class14.string_4;
		}
		process.StartInfo.LoadUserProfile = true;
		process.StartInfo.WorkingDirectory = global::ns3.Class14.smethod_1(global::System.Windows.Forms.Application.StartupPath);
		process.StartInfo.FileName = text;
		global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
		stringBuilder.Append("-HOSTRUNAS ");
		for (int j = 0; j <= string_12.GetUpperBound(0); j++)
		{
			if (j > 0)
			{
				stringBuilder.Append(" \"");
			}
			else
			{
				stringBuilder.Append("\"");
			}
			stringBuilder.Append(string_12[j]);
			stringBuilder.Append("\"");
		}
		process.StartInfo.Arguments = stringBuilder.ToString();
		process.StartInfo.UseShellExecute = false;
		try
		{
			if (process.Start())
			{
				process.WaitForExit();
				return process.ExitCode;
			}
			return -1;
		}
		catch (global::System.ComponentModel.Win32Exception ex)
		{
			global::System.Console.WriteLine(ex.Message);
			return -1;
		}
		catch (global::System.SystemException ex2)
		{
			global::System.Console.WriteLine(ex2.Message);
			return -1;
		}
	}
	if (global::ns3.Class14.bool_4)
	{
		string text2 = global::System.Windows.Forms.Application.ExecutablePath.Replace('\\', '-');
		bool flag;
		global::ns3.Class14.mutex_0 = new global::System.Threading.Mutex(false, text2, out flag);
		if (!flag)
		{
			global::System.Console.WriteLine("Another instance of this application is already running");
			return -1;
		}
	}
	if (global::ns3.Class14.bool_5 && !global::ns3.Class14.smethod_10())
	{
		return -1;
	}
	if (global::ns3.Class14.int_12 == 1)
	{
		global::System.DateTime now = global::System.DateTime.Now;
		global::System.DateTime dateTime = new global::System.DateTime(global::ns3.Class14.int_17, global::ns3.Class14.int_16, global::ns3.Class14.int_15);
		if ((now - dateTime).Days > 3)
		{
			global::System.Console.WriteLine("This script package was created with a\ntrial version of the SAPIEN Script Packager and is now expired.\nPlease re-package with a licensed version your SAPIEN product.");
			return -1;
		}
		global::System.Console.WriteLine("This script package was created with a\ntrial version of the SAPIEN Script Packager.");
	}
	bool flag2 = false;
	if (global::ns3.Class14.string_4.Length != 0)
	{
		try
		{
			if (!@class.method_0("", global::ns3.Class14.string_4, global::ns3.Class14.string_5))
			{
				global::System.Console.WriteLine("Impersonation failed, aborting process\n");
				return -1;
			}
			flag2 = true;
		}
		catch (global::System.Exception ex3)
		{
			global::System.Console.WriteLine("Impersonation failed, aborting process\n");
			global::System.Console.WriteLine(ex3.Message);
			return -1;
		}
	}
	global::ns5.Class6.Enum0 @enum = global::ns5.Class6.Enum0.const_0;
	global::ns5.Class6.Enum0 enum2 = global::ns5.Class6.Enum0.const_0;
	bool flag3 = false;
	bool flag4 = false;
	if (global::ns3.Class14.bool_9 && global::ns3.Class14.smethod_11() && global::ns5.Class6.smethod_3() != global::ns5.Class6.Enum0.const_1)
	{
		enum2 = global::ns5.Class6.smethod_6();
		flag4 = true;
	}
	if (global::ns3.Class14.bool_9 && global::ns5.Class6.smethod_3() != global::ns5.Class6.Enum0.const_1)
	{
		global::System.Console.WriteLine("Transcript not disabled, aborting process");
		return -1;
	}
	if (global::ns3.Class14.bool_8 && global::ns3.Class14.smethod_11() && global::ns5.Class6.smethod_2() != global::ns5.Class6.Enum0.const_1)
	{
		@enum = global::ns5.Class6.smethod_5();
		flag3 = true;
	}
	if (global::ns3.Class14.bool_7 || global::ns3.Class14.bool_8)
	{
		global::ns5.Class6.Enum0 enum3 = global::ns5.Class6.smethod_2();
		global::ns5.Class6.Enum0 enum4 = global::ns5.Class6.smethod_1();
		if (enum3 == global::ns5.Class6.Enum0.const_2)
		{
			global::System.Console.WriteLine("Script Block Logging enabled, aborting process");
			return -1;
		}
		if (enum3 == global::ns5.Class6.Enum0.const_0 && enum4 == global::ns5.Class6.Enum0.const_2)
		{
			global::System.Console.WriteLine("Per user Script Block Logging enabled, aborting process");
			return -1;
		}
		if (enum3 == global::ns5.Class6.Enum0.const_0 && enum4 == global::ns5.Class6.Enum0.const_0)
		{
			global::System.Console.WriteLine("Script Block Logging not disabled, aborting process");
			return -1;
		}
	}
	global::ns5.Class16 class2 = new global::ns5.Class16();
	class2.string_8 = text;
	try
	{
		if (!class2.method_0(false, global::ns3.Class14.int_14))
		{
			global::System.Console.WriteLine("PowerShell cannot be instantiated");
			global::System.Console.WriteLine(class2.string_0);
			return -1;
		}
	}
	catch (global::System.Exception ex4)
	{
		global::System.Console.WriteLine("PowerShell cannot be instantiated");
		global::System.Console.WriteLine(ex4.Message);
		return -1;
	}
	class2.OutputMode = 0;
	global::System.Console.OutputEncoding = global::System.Text.Encoding.UTF8;
	global::System.IntPtr intPtr = global::ns3.Class14.FindResource(hinstance, new global::System.IntPtr(4), new global::System.IntPtr(10));
	uint num2 = global::ns3.Class14.SizeofResource(hinstance, intPtr);
	byte[] array3 = new byte[num2];
	global::System.Runtime.InteropServices.Marshal.Copy(global::ns3.Class14.LockResource(global::ns3.Class14.LoadResource(hinstance, intPtr)), array3, 0, (int)num2);
	string text3;
	if (!global::ns3.Class14.bool_6)
	{
		byte[] array4 = new byte[]
		{
			66, 67, 51, 55, 51, 65, 67, 65, 50, 55,
			57, 50, 52, 69, 66, 69, 65, 50, 57, 68,
			50, 65, 50, 50, 69, 51, 52, 56, 65, 67,
			66, 52, 0
		};
		byte[] array5 = global::ns3.Class14.smethod_8(array3, (int)num2, array4);
		global::System.Text.Encoding encoding = global::System.Text.Encoding.GetEncoding(1252);
		if (array5[0] == 255 && array5[1] == 254)
		{
			text3 = global::System.Text.Encoding.Unicode.GetString(array5).Substring(1);
		}
		else if (array5[0] == 239 && array5[1] == 187 && array5[2] == 191)
		{
			text3 = global::System.Text.Encoding.UTF8.GetString(array5).Substring(1);
		}
		else
		{
			text3 = encoding.GetString(array5);
		}
	}
	else
	{
		global::System.Security.SecureString secureString2 = new global::System.Security.SecureString();
		secureString2.AppendChar('B');
		secureString2.AppendChar('C');
		secureString2.AppendChar('3');
		secureString2.AppendChar('7');
		secureString2.AppendChar('3');
		secureString2.AppendChar('A');
		secureString2.AppendChar('C');
		secureString2.AppendChar('A');
		secureString2.AppendChar('2');
		secureString2.AppendChar('7');
		secureString2.AppendChar('9');
		secureString2.AppendChar('2');
		secureString2.AppendChar('4');
		secureString2.AppendChar('E');
		secureString2.AppendChar('B');
		secureString2.AppendChar('E');
		secureString2.AppendChar('A');
		secureString2.AppendChar('2');
		secureString2.AppendChar('9');
		secureString2.AppendChar('D');
		secureString2.AppendChar('2');
		secureString2.AppendChar('A');
		secureString2.AppendChar('2');
		secureString2.AppendChar('2');
		secureString2.AppendChar('E');
		secureString2.AppendChar('3');
		secureString2.AppendChar('4');
		secureString2.AppendChar('8');
		secureString2.AppendChar('A');
		secureString2.AppendChar('C');
		secureString2.AppendChar('B');
		secureString2.AppendChar('4');
		text3 = global::ns3.Class14.smethod_5(array3, global::ns3.Class14.smethod_3(secureString2));
	}
	class2.string_7 = "";
	global::System.Text.StringBuilder stringBuilder2 = new global::System.Text.StringBuilder();
	int num3 = 0;
	if (string_12.Length != 0 && string_12[0].CompareTo("-HOSTRUNAS") == 0)
	{
		num3 = 1;
	}
	for (int k = num3; k <= string_12.GetUpperBound(0); k++)
	{
		if (k > num3)
		{
			stringBuilder2.Append(" \"");
		}
		else
		{
			stringBuilder2.Append("\"");
		}
		stringBuilder2.Append(string_12[k]);
		stringBuilder2.Append("\"");
	}
	class2.string_9 = stringBuilder2.ToString();
	try
	{
		class2.method_3(text3, string_12);
	}
	catch (global::System.Exception ex5)
	{
		global::System.Console.WriteLine("Error executing script.");
		global::System.Console.WriteLine(ex5.Message);
		global::System.Console.WriteLine(ex5.Source);
		global::System.Console.WriteLine(ex5.StackTrace);
		global::System.Console.WriteLine(ex5.TargetSite);
	}
	int num4 = class2.int_4;
	if (flag3)
	{
		global::ns5.Class6.smethod_7(@enum);
	}
	if (flag4)
	{
		global::ns5.Class6.smethod_8(enum2);
	}
	try
	{
		if (flag2)
		{
			@class.method_1();
		}
	}
	catch (global::System.Exception)
	{
	}
	class2.runspace_0.Close();
	try
	{
		if (global::ns3.Class14.mutex_0 != null)
		{
			global::ns3.Class14.mutex_0.ReleaseMutex();
		}
	}
	catch (global::System.Exception)
	{
	}
	return num4;
}
