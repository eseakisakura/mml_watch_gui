﻿using System;
using System.Diagnostics;

class Program
{
  public static void Main()
  {

	string dir_path= System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);	// exeカレント取得
	System.IO.Directory.SetCurrentDirectory(dir_path);	// <- argsカレントを変更

	// Console.WriteLine(System.IO.Directory.GetCurrentDirectory());


	string abs= " -ExecutionPolicy RemoteSigned -Sta -File .\\script\\common.ps1 mml_watch";
	// [\\ -> \] @"ヒアドキュメント"

	// Console.WriteLine(abs);

	ProcessStartInfo dp= new ProcessStartInfo();

	dp.FileName= "pwsh.exe";

	dp.UseShellExecute= false;	// シェル窓を開くか
	dp.CreateNoWindow= true;	// call appの窓を開かない

	dp.Arguments= abs;

	Process p= Process.Start(dp);
	// Console.ReadKey();
	p.WaitForExit();
	p.Close();
  }
}
