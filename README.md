<h1>mml watch GUI</h1>
<br>
Chiptune MMLコンパイラへ、GUIを提供するフロントエンドです。<br>
"ppmck", "nsdLib", "P.M.D"へ対応します。<br>
<br>
GUI部も含めて、総Powershellで組まれており、それぞれがスタンドアロン(単体)で起動します。<br>
<br>
<br>
<h5>起動済み確認環境: <br>
 <br>
win10(22H2)+ Powershell7.3(.NET7)<br>
win10(22H2)+ Powershell5(.NET Framework4.8)<br>
<br>
winXP+ Powershell2(.NET Framework3.5) - 旧版 ver4.5.2<br>
</h5>

<h4>
説明書及び、必須ソフトウェアのリンク <br>
・<a href="https://eseakisakura.github.io/mml_watch_gui/"> Mml Watch GUI - download</a><br>
</h4>
<br>
<br>
<table><tr><td>・Mml Watch GUI</td><td>mmlチップチューンのfront end</td>
</tr><tr><td>・FM Synthesis Chip - Tone Editor</td><td>2op.4op.対応FM音源音色エディタ</td>
</tr><tr><td>・Guitar Arpeggio - MML Generator</td><td>ギターアルペジオジェネレータ</td>
</tr></table>
<br>
※Watch.cmdなどのバッチファイルによる起動であれば、<br>
.NET Framework3.5以上、PowerShell2以上なら動くと思います。<br>
<br>
<br>
<h4><img src="./image/MW_icon.png"> Mml Watch GUI</h4>

<table><tr><td>
<img src="./image/MML_wth.png"><br>
</td><td>
<div>
mmlによるchiptuneコンパイラをGUI化したフロントエンドです。<br>
ファイル更新チェッカとして機能、自動再生までサポートします。
ppmck、nsdLib、PMDに対応しています。<br>
</div></td></tr></table>

<h4>■ Setting Panel</h4>

<table><tr><td>
<img src="./image/SETTING_w.png"><br>
</td><td>
<div>
必要なソフトウェアを登録する環境設定です。
リストボックスへDrug&Dropすることでパスを登録します。<br>
(以下のFM Editor、Arp Generatorも、このパス環境リストを共有します。)<br>
</div></td></tr></table>
<br>
<h4><img src="./image/FE_icon.png"> FM Synthesis Chip - Tone Editor</h4>

<table><tr><td>
<img src="./image/FM_edt.png"><br>
</td><td>
<div>
2op(vrc7, opl), 4op(opn, opm)対応のFM音源音色エディタです。<br>
<br>
生成音色の試聴、preset呼び出し、音色の一時保存や、<br>
2op.(ppmck,nsdLibのレジスタ音色含む)、<br>
4op.(PMD,fmp7,mxdrv各音色形式)の、<br>
インポート、エクスポートができます。<br>
</div></td></tr></table>

<h4>■ FM Editor Operator window</h4>

<table><tr><td>
<img src="./image/FM_4op.png"><br>
</td><td>
<div>
上記、FM音源音色エディタのサブウィンドウです。<br>
<br>
音色エディタのノブに連動し、合成波形表示が<br>
変わります。<br>
(ウィンドウ内をクリックすることで、<br>
エディットするオペレータ切替えができます。)<br>
</div></td></tr></table>
<br>
<h4><img src="./image/AG_icon.png">Guitar Arpeggio - MML Generator</h4>

<table><tr><td>
<img src="./image/GUITAR_arp.png"><br>
</td><td>
<div>
ギターアルペジオMMLジェネレータです。<br>
マルチトラックにMMLを自動的に振り分け、串抜きMMLを自動生成します。<br>
<br>
chordアサインのち、アルペジオナンバーを打つことで、各コンパイラに対応したmmlを生成します。<br>
</div></td></tr></table>
