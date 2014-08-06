<%@ Page Language="C#" Inherits="CuteEditor.EditorUtilityPage" %>
<script runat="server">
string GetDialogQueryString;
override protected void OnInit(EventArgs args)
{
	if(Context.Request.QueryString["Dialog"]=="Standard")
	{	
	if(Context.Request.QueryString["IsFrame"]==null)
	{
		string FrameSrc="colorpicker_basic.aspx?IsFrame=1&"+Request.ServerVariables["QUERY_STRING"];
		CuteEditor.CEU.WriteDialogOuterFrame(Context,"[[MoreColors]]",FrameSrc);
		Context.Response.End();
	}
	}
	string s="";
	if(Context.Request.QueryString["Dialog"]=="Standard")	
		s="&Dialog=Standard";
	
	GetDialogQueryString="Theme="+Context.Request.QueryString["Theme"]+s;	
	base.OnInit(args);
}
</script>
<html xmlns="http://www.w3.org/1999/xhtml">
	<head runat="server">
		<meta http-equiv="Page-Enter" content="blendTrans(Duration=0.1)" />
		<meta http-equiv="Page-Exit" content="blendTrans(Duration=0.1)" />
		<script type="text/javascript" src="Load.ashx?type=dialogscript&verfix=1006&file=DialogHead.js"></script>
		<script type="text/javascript" src="Load.ashx?type=dialogscript&verfix=1006&file=Dialog_ColorPicker.js"></script>
		<link href='Load.ashx?type=themecss&file=dialog.css&theme=[[_Theme_]]' type="text/css"
			rel="stylesheet" />
		<style type="text/css">
			.colorcell
			{
				width:16px;
				height:17px;
				cursor:hand;
			}
			.colordiv,.customdiv
			{
				border:solid 1px #808080;
				width:16px;
				height:17px;
				font-size:1px;
			}
			#ajaxdiv{padding:10px;margin:0;text-align:center; background:#eeeeee;}
		</style>
		<title>[[NamedColors]]</title>
		<script>
								
		var OxOcb05=["Green","#008000","Lime","#00FF00","Teal","#008080","Aqua","#00FFFF","Navy","#000080","Blue","#0000FF","Purple","#800080","Fuchsia","#FF00FF","Maroon","#800000","Red","#FF0000","Olive","#808000","Yellow","#FFFF00","White","#FFFFFF","Silver","#C0C0C0","Gray","#808080","Black","#000000","DarkOliveGreen","#556B2F","DarkGreen","#006400","DarkSlateGray","#2F4F4F","SlateGray","#708090","DarkBlue","#00008B","MidnightBlue","#191970","Indigo","#4B0082","DarkMagenta","#8B008B","Brown","#A52A2A","DarkRed","#8B0000","Sienna","#A0522D","SaddleBrown","#8B4513","DarkGoldenrod","#B8860B","Beige","#F5F5DC","HoneyDew","#F0FFF0","DimGray","#696969","OliveDrab","#6B8E23","ForestGreen","#228B22","DarkCyan","#008B8B","LightSlateGray","#778899","MediumBlue","#0000CD","DarkSlateBlue","#483D8B","DarkViolet","#9400D3","MediumVioletRed","#C71585","IndianRed","#CD5C5C","Firebrick","#B22222","Chocolate","#D2691E","Peru","#CD853F","Goldenrod","#DAA520","LightGoldenrodYellow","#FAFAD2","MintCream","#F5FFFA","DarkGray","#A9A9A9","YellowGreen","#9ACD32","SeaGreen","#2E8B57","CadetBlue","#5F9EA0","SteelBlue","#4682B4","RoyalBlue","#4169E1","BlueViolet","#8A2BE2","DarkOrchid","#9932CC","DeepPink","#FF1493","RosyBrown","#BC8F8F","Crimson","#DC143C","DarkOrange","#FF8C00","BurlyWood","#DEB887","DarkKhaki","#BDB76B","LightYellow","#FFFFE0","Azure","#F0FFFF","LightGray","#D3D3D3","LawnGreen","#7CFC00","MediumSeaGreen","#3CB371","LightSeaGreen","#20B2AA","DeepSkyBlue","#00BFFF","DodgerBlue","#1E90FF","SlateBlue","#6A5ACD","MediumOrchid","#BA55D3","PaleVioletRed","#DB7093","Salmon","#FA8072","OrangeRed","#FF4500","SandyBrown","#F4A460","Tan","#D2B48C","Gold","#FFD700","Ivory","#FFFFF0","GhostWhite","#F8F8FF","Gainsboro","#DCDCDC","Chartreuse","#7FFF00","LimeGreen","#32CD32","MediumAquamarine","#66CDAA","DarkTurquoise","#00CED1","CornflowerBlue","#6495ED","MediumSlateBlue","#7B68EE","Orchid","#DA70D6","HotPink","#FF69B4","LightCoral","#F08080","Tomato","#FF6347","Orange","#FFA500","Bisque","#FFE4C4","Khaki","#F0E68C","Cornsilk","#FFF8DC","Linen","#FAF0E6","WhiteSmoke","#F5F5F5","GreenYellow","#ADFF2F","DarkSeaGreen","#8FBC8B","Turquoise","#40E0D0","MediumTurquoise","#48D1CC","SkyBlue","#87CEEB","MediumPurple","#9370DB","Violet","#EE82EE","LightPink","#FFB6C1","DarkSalmon","#E9967A","Coral","#FF7F50","NavajoWhite","#FFDEAD","BlanchedAlmond","#FFEBCD","PaleGoldenrod","#EEE8AA","Oldlace","#FDF5E6","Seashell","#FFF5EE","PaleGreen","#98FB98","SpringGreen","#00FF7F","Aquamarine","#7FFFD4","PowderBlue","#B0E0E6","LightSkyBlue","#87CEFA","LightSteelBlue","#B0C4DE","Plum","#DDA0DD","Pink","#FFC0CB","LightSalmon","#FFA07A","Wheat","#F5DEB3","Moccasin","#FFE4B5","AntiqueWhite","#FAEBD7","LemonChiffon","#FFFACD","FloralWhite","#FFFAF0","Snow","#FFFAFA","AliceBlue","#F0F8FF","LightGreen","#90EE90","MediumSpringGreen","#00FA9A","PaleTurquoise","#AFEEEE","LightCyan","#E0FFFF","LightBlue","#ADD8E6","Lavender","#E6E6FA","Thistle","#D8BFD8","MistyRose","#FFE4E1","Peachpuff","#FFDAB9","PapayaWhip","#FFEFD5"];var colorlist=[{n:OxOcb05[0],h:OxOcb05[1]},{n:OxOcb05[2],h:OxOcb05[3]},{n:OxOcb05[4],h:OxOcb05[5]},{n:OxOcb05[6],h:OxOcb05[7]},{n:OxOcb05[8],h:OxOcb05[9]},{n:OxOcb05[10],h:OxOcb05[11]},{n:OxOcb05[12],h:OxOcb05[13]},{n:OxOcb05[14],h:OxOcb05[15]},{n:OxOcb05[16],h:OxOcb05[17]},{n:OxOcb05[18],h:OxOcb05[19]},{n:OxOcb05[20],h:OxOcb05[21]},{n:OxOcb05[22],h:OxOcb05[23]},{n:OxOcb05[24],h:OxOcb05[25]},{n:OxOcb05[26],h:OxOcb05[27]},{n:OxOcb05[28],h:OxOcb05[29]},{n:OxOcb05[30],h:OxOcb05[31]}];var colormore=[{n:OxOcb05[32],h:OxOcb05[33]},{n:OxOcb05[34],h:OxOcb05[35]},{n:OxOcb05[36],h:OxOcb05[37]},{n:OxOcb05[38],h:OxOcb05[39]},{n:OxOcb05[40],h:OxOcb05[41]},{n:OxOcb05[42],h:OxOcb05[43]},{n:OxOcb05[44],h:OxOcb05[45]},{n:OxOcb05[46],h:OxOcb05[47]},{n:OxOcb05[48],h:OxOcb05[49]},{n:OxOcb05[50],h:OxOcb05[51]},{n:OxOcb05[52],h:OxOcb05[53]},{n:OxOcb05[54],h:OxOcb05[55]},{n:OxOcb05[56],h:OxOcb05[57]},{n:OxOcb05[58],h:OxOcb05[59]},{n:OxOcb05[60],h:OxOcb05[61]},{n:OxOcb05[62],h:OxOcb05[63]},{n:OxOcb05[64],h:OxOcb05[65]},{n:OxOcb05[66],h:OxOcb05[67]},{n:OxOcb05[68],h:OxOcb05[69]},{n:OxOcb05[70],h:OxOcb05[71]},{n:OxOcb05[72],h:OxOcb05[73]},{n:OxOcb05[74],h:OxOcb05[75]},{n:OxOcb05[76],h:OxOcb05[77]},{n:OxOcb05[78],h:OxOcb05[79]},{n:OxOcb05[80],h:OxOcb05[81]},{n:OxOcb05[82],h:OxOcb05[83]},{n:OxOcb05[84],h:OxOcb05[85]},{n:OxOcb05[86],h:OxOcb05[87]},{n:OxOcb05[88],h:OxOcb05[89]},{n:OxOcb05[90],h:OxOcb05[91]},{n:OxOcb05[92],h:OxOcb05[93]},{n:OxOcb05[94],h:OxOcb05[95]},{n:OxOcb05[96],h:OxOcb05[97]},{n:OxOcb05[98],h:OxOcb05[99]},{n:OxOcb05[100],h:OxOcb05[101]},{n:OxOcb05[102],h:OxOcb05[103]},{n:OxOcb05[104],h:OxOcb05[105]},{n:OxOcb05[106],h:OxOcb05[107]},{n:OxOcb05[108],h:OxOcb05[109]},{n:OxOcb05[110],h:OxOcb05[111]},{n:OxOcb05[112],h:OxOcb05[113]},{n:OxOcb05[114],h:OxOcb05[115]},{n:OxOcb05[116],h:OxOcb05[117]},{n:OxOcb05[118],h:OxOcb05[119]},{n:OxOcb05[120],h:OxOcb05[121]},{n:OxOcb05[122],h:OxOcb05[123]},{n:OxOcb05[124],h:OxOcb05[125]},{n:OxOcb05[126],h:OxOcb05[127]},{n:OxOcb05[128],h:OxOcb05[129]},{n:OxOcb05[130],h:OxOcb05[131]},{n:OxOcb05[132],h:OxOcb05[133]},{n:OxOcb05[134],h:OxOcb05[135]},{n:OxOcb05[136],h:OxOcb05[137]},{n:OxOcb05[138],h:OxOcb05[139]},{n:OxOcb05[140],h:OxOcb05[141]},{n:OxOcb05[142],h:OxOcb05[143]},{n:OxOcb05[144],h:OxOcb05[145]},{n:OxOcb05[146],h:OxOcb05[147]},{n:OxOcb05[148],h:OxOcb05[149]},{n:OxOcb05[150],h:OxOcb05[151]},{n:OxOcb05[152],h:OxOcb05[153]},{n:OxOcb05[154],h:OxOcb05[155]},{n:OxOcb05[156],h:OxOcb05[157]},{n:OxOcb05[158],h:OxOcb05[159]},{n:OxOcb05[160],h:OxOcb05[161]},{n:OxOcb05[162],h:OxOcb05[163]},{n:OxOcb05[164],h:OxOcb05[165]},{n:OxOcb05[166],h:OxOcb05[167]},{n:OxOcb05[168],h:OxOcb05[169]},{n:OxOcb05[170],h:OxOcb05[171]},{n:OxOcb05[172],h:OxOcb05[173]},{n:OxOcb05[174],h:OxOcb05[175]},{n:OxOcb05[176],h:OxOcb05[177]},{n:OxOcb05[178],h:OxOcb05[179]},{n:OxOcb05[180],h:OxOcb05[181]},{n:OxOcb05[182],h:OxOcb05[183]},{n:OxOcb05[184],h:OxOcb05[185]},{n:OxOcb05[186],h:OxOcb05[187]},{n:OxOcb05[188],h:OxOcb05[189]},{n:OxOcb05[190],h:OxOcb05[191]},{n:OxOcb05[192],h:OxOcb05[193]},{n:OxOcb05[194],h:OxOcb05[195]},{n:OxOcb05[196],h:OxOcb05[197]},{n:OxOcb05[198],h:OxOcb05[199]},{n:OxOcb05[200],h:OxOcb05[201]},{n:OxOcb05[202],h:OxOcb05[203]},{n:OxOcb05[204],h:OxOcb05[205]},{n:OxOcb05[206],h:OxOcb05[207]},{n:OxOcb05[208],h:OxOcb05[209]},{n:OxOcb05[210],h:OxOcb05[211]},{n:OxOcb05[212],h:OxOcb05[213]},{n:OxOcb05[214],h:OxOcb05[215]},{n:OxOcb05[216],h:OxOcb05[217]},{n:OxOcb05[218],h:OxOcb05[219]},{n:OxOcb05[220],h:OxOcb05[221]},{n:OxOcb05[156],h:OxOcb05[157]},{n:OxOcb05[222],h:OxOcb05[223]},{n:OxOcb05[224],h:OxOcb05[225]},{n:OxOcb05[226],h:OxOcb05[227]},{n:OxOcb05[228],h:OxOcb05[229]},{n:OxOcb05[230],h:OxOcb05[231]},{n:OxOcb05[232],h:OxOcb05[233]},{n:OxOcb05[234],h:OxOcb05[235]},{n:OxOcb05[236],h:OxOcb05[237]},{n:OxOcb05[238],h:OxOcb05[239]},{n:OxOcb05[240],h:OxOcb05[241]},{n:OxOcb05[242],h:OxOcb05[243]},{n:OxOcb05[244],h:OxOcb05[245]},{n:OxOcb05[246],h:OxOcb05[247]},{n:OxOcb05[248],h:OxOcb05[249]},{n:OxOcb05[250],h:OxOcb05[251]},{n:OxOcb05[252],h:OxOcb05[253]},{n:OxOcb05[254],h:OxOcb05[255]},{n:OxOcb05[256],h:OxOcb05[257]},{n:OxOcb05[258],h:OxOcb05[259]},{n:OxOcb05[260],h:OxOcb05[261]},{n:OxOcb05[262],h:OxOcb05[263]},{n:OxOcb05[264],h:OxOcb05[265]},{n:OxOcb05[266],h:OxOcb05[267]},{n:OxOcb05[268],h:OxOcb05[269]},{n:OxOcb05[270],h:OxOcb05[271]},{n:OxOcb05[272],h:OxOcb05[273]}];
		
		</script>
	</head>
	<body>
		<div id="ajaxdiv">
			<div class="tab-pane-control tab-pane" id="tabPane1">
				<div class="tab-row">
					<h2 class="tab">
						<a tabindex="-1" href='colorpicker.aspx?<%=GetDialogQueryString%>'>
							<span style="white-space:nowrap;">
								[[WebPalette]]
							</span>
						</a>
					</h2>
					<h2 class="tab selected">
							<a tabindex="-1" href='colorpicker_basic.aspx?<%=GetDialogQueryString%>'>
								<span style="white-space:nowrap;">
									[[NamedColors]]
								</span>
							</a>
					</h2>
					<h2 class="tab">
							<a tabindex="-1" href='colorpicker_more.aspx?<%=GetDialogQueryString%>'>
								<span style="white-space:nowrap;">
									[[CustomColor]]
								</span>
							</a>
					</h2>
				</div>
				<div class="tab-page">			
					<table class="colortable" align="center">
						<tr>
							<td colspan="16" height="16"><p align="left">Basic:
								</p>
							</td>
						</tr>
						<tr>
							<script>
								var OxO4731=["length","\x3Ctd class=\x27colorcell\x27\x3E\x3Cdiv class=\x27colordiv\x27 style=\x27background-color:","\x27 title=\x27"," ","\x27 cname=\x27","\x27 cvalue=\x27","\x27\x3E\x3C/div\x3E\x3C/td\x3E",""];var arr=[];for(var i=0;i<colorlist[OxO4731[0]];i++){arr.push(OxO4731[1]);arr.push(colorlist[i].n);arr.push(OxO4731[2]);arr.push(colorlist[i].n);arr.push(OxO4731[3]);arr.push(colorlist[i].h);arr.push(OxO4731[4]);arr.push(colorlist[i].n);arr.push(OxO4731[5]);arr.push(colorlist[i].h);arr.push(OxO4731[6]);} ;document.write(arr.join(OxO4731[7]));
							</script>
						</tr>
						<tr>
							<td colspan="16" height="12"><p align="left"></p>
							</td>
						</tr>
						<tr>
							<td colspan="16"><p align="left">Additional:
								</p>
							</td>
						</tr>
						<script>
							var OxO5e83=["length","\x3Ctr\x3E","\x3Ctd class=\x27colorcell\x27\x3E\x3Cdiv class=\x27colordiv\x27 style=\x27background-color:","\x27 title=\x27"," ","\x27 cname=\x27","\x27 cvalue=\x27","\x27\x3E\x3C/div\x3E\x3C/td\x3E","\x3C/tr\x3E",""];var arr=[];for(var i=0;i<colormore[OxO5e83[0]];i++){if(i%16==0){arr.push(OxO5e83[1]);} ;arr.push(OxO5e83[2]);arr.push(colormore[i].n);arr.push(OxO5e83[3]);arr.push(colormore[i].n);arr.push(OxO5e83[4]);arr.push(colormore[i].h);arr.push(OxO5e83[5]);arr.push(colormore[i].n);arr.push(OxO5e83[6]);arr.push(colormore[i].h);arr.push(OxO5e83[7]);if(i%16==15){arr.push(OxO5e83[8]);} ;} ;if(colormore%16>0){arr.push(OxO5e83[8]);} ;document.write(arr.join(OxO5e83[9]));
						</script>
						<tr>
							<td colspan="16" height="8">
							</td>
						</tr>
						<tr>
							<td colspan="16" height="12">
								<input checked id="CheckboxColorNames" style="width: 16px; height: 20px" type="checkbox">
								<span style="width: 118px;">Use color names</span>
							</td>
						</tr>
						<tr>
							<td colspan="16" height="12">
							</td>
						</tr>
						<tr>
							<td colspan="16" valign="middle" height="24">
							<span style="height:24px;width:50px;vertical-align:middle;">Color : </span>&nbsp;
							<input type="text" id="divpreview" size="7" maxlength="7" style="width:180px;height:24px;border:#a0a0a0 1px solid; Padding:4;"/>
					
							</td>
						</tr>
				</table>
			</div>
		</div>
		<div id="container-bottom">
			<input type="button" id="buttonok" value="[[OK]]" class="formbutton" style="width:70px"	onclick="do_insert();" /> 
			&nbsp;&nbsp;&nbsp;&nbsp; 
			<input type="button" id="buttoncancel" value="[[Cancel]]" class="formbutton" style="width:70px"	onclick="do_Close();" />	
		</div>
	</div>
	</body>
</html>

