﻿using System;
using System.Diagnostics;

class Program
{
  public static void Main()
  {

	string dir_path= System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
	System.IO.Directory.SetCurrentDirectory(dir_path);

	// Console.WriteLine(System.IO.Directory.GetCurrentDirectory());


	string abs= " -ExecutionPolicy RemoteSigned -Sta -File .\\script\\common.ps1 fm_editor";

	// Console.WriteLine(abs);

	ProcessStartInfo dp= new ProcessStartInfo();

	dp.FileName= "powershell.exe";

	dp.UseShellExecute= false;
	dp.CreateNoWindow= true;

	dp.Arguments= abs;

	Process p= Process.Start(dp);
	// Console.ReadKey();
	p.WaitForExit();
	p.Close();
  }
}
