var OxOd832=["SetStyle","length","","GetStyle","GetText",":",";","cssText","inp_color","inp_color_Preview","tb_image","btnbrowse","sel_bgrepeat","sel_bgattach","sel_hor","tb_hor","sel_hor_unit","sel_ver","tb_ver","sel_ver_unit","outer","div_demo","onclick","value","disabled","selectedIndex","style","backgroundImage","backgroundColor","backgroundRepeat","backgroundAttachment","backgroundPositionX","options","backgroundPositionY","url(",")","background-image","backgroundPosition","none"];function pause(Ox4a1){var Oxa8= new Date();var Ox4a2=Oxa8.getTime()+Ox4a1;while(true){Oxa8= new Date();if(Oxa8.getTime()>Ox4a2){return ;} ;} ;} ;function StyleClass(Ox201){var Ox4a4=[];var Ox4a5={};if(Ox201){Ox4aa();} ;this[OxOd832[0]]=function SetStyle(name,Ox4f,Ox4a7){name=name.toLowerCase();for(var i=0;i<Ox4a4[OxOd832[1]];i++){if(Ox4a4[i]==name){break ;} ;} ;Ox4a4[i]=name;Ox4a5[name]=Ox4f?(Ox4f+(Ox4a7||OxOd832[2])):OxOd832[2];} ;this[OxOd832[3]]=function GetStyle(name){name=name.toLowerCase();return Ox4a5[name]||OxOd832[2];} ;this[OxOd832[4]]=function Ox4a9(){var Ox201=OxOd832[2];for(var i=0;i<Ox4a4[OxOd832[1]];i++){var Ox27=Ox4a4[i];var p=Ox4a5[Ox27];if(p){Ox201+=Ox27+OxOd832[5]+p+OxOd832[6];} ;} ;return Ox201;} ;function Ox4aa(){var arr=Ox201.split(OxOd832[6]);for(var i=0;i<arr[OxOd832[1]];i++){var p=arr[i].split(OxOd832[5]);var Ox27=p[0].replace(/^\s+/g,OxOd832[2]).replace(/\s+$/g,OxOd832[2]).toLowerCase();Ox4a4[Ox4a4[OxOd832[1]]]=Ox27;Ox4a5[Ox27]=p[1];} ;} ;} ;function GetStyle(Ox137,name){return  new StyleClass(Ox137.cssText).GetStyle(name);} ;function SetStyle(Ox137,name,Ox4f,Ox4ab){var Ox4ac= new StyleClass(Ox137.cssText);Ox4ac.SetStyle(name,Ox4f,Ox4ab);Ox137[OxOd832[7]]=Ox4ac.GetText();} ;function ParseFloatToString(Ox24){var Ox8=parseFloat(Ox24);if(isNaN(Ox8)){return OxOd832[2];} ;return Ox8+OxOd832[2];} ;var inp_color=Window_GetElement(window,OxOd832[8],true);var inp_color_Preview=Window_GetElement(window,OxOd832[9],true);var tb_image=Window_GetElement(window,OxOd832[10],true);var btnbrowse=Window_GetElement(window,OxOd832[11],true);var sel_bgrepeat=Window_GetElement(window,OxOd832[12],true);var sel_bgattach=Window_GetElement(window,OxOd832[13],true);var sel_hor=Window_GetElement(window,OxOd832[14],true);var tb_hor=Window_GetElement(window,OxOd832[15],true);var sel_hor_unit=Window_GetElement(window,OxOd832[16],true);var sel_ver=Window_GetElement(window,OxOd832[17],true);var tb_ver=Window_GetElement(window,OxOd832[18],true);var sel_ver_unit=Window_GetElement(window,OxOd832[19],true);var outer=Window_GetElement(window,OxOd832[20],true);var div_demo=Window_GetElement(window,OxOd832[21],true);btnbrowse[OxOd832[22]]=function btnbrowse_onclick(){function Ox35c(Ox13e){if(Ox13e){tb_image[OxOd832[23]]=Ox13e;FireUIChanged();} ;} ;editor.SetNextDialogWindow(window);if(Browser_IsSafari()){editor.ShowSelectImageDialog(Ox35c,tb_image.value,tb_image);} else {editor.ShowSelectImageDialog(Ox35c,tb_image.value);} ;} ;UpdateState=function UpdateState_Background(){tb_hor[OxOd832[24]]=sel_hor_unit[OxOd832[24]]=(sel_hor[OxOd832[25]]>0);tb_ver[OxOd832[24]]=sel_ver_unit[OxOd832[24]]=(sel_ver[OxOd832[25]]>0);div_demo[OxOd832[26]][OxOd832[7]]=element[OxOd832[26]][OxOd832[7]];} ;SyncToView=function SyncToView_Background(){tb_image[OxOd832[23]]=element[OxOd832[26]][OxOd832[27]];FixTbImage();inp_color[OxOd832[23]]=element[OxOd832[26]][OxOd832[28]];inp_color[OxOd832[26]][OxOd832[28]]=element[OxOd832[26]][OxOd832[28]];inp_color_Preview[OxOd832[26]][OxOd832[28]]=element[OxOd832[26]][OxOd832[28]];sel_bgrepeat[OxOd832[23]]=element[OxOd832[26]][OxOd832[29]];sel_bgattach[OxOd832[23]]=element[OxOd832[26]][OxOd832[30]];sel_hor[OxOd832[23]]=element[OxOd832[26]][OxOd832[31]];sel_hor_unit[OxOd832[25]]=0;if(sel_hor[OxOd832[25]]==-1){if(ParseFloatToString(element[OxOd832[26]].backgroundPositionX)){tb_hor[OxOd832[23]]=ParseFloatToString(element[OxOd832[26]].backgroundPositionX);for(var i=0;i<sel_hor_unit[OxOd832[32]][OxOd832[1]];i++){var Ox142=sel_hor_unit[OxOd832[32]][i][OxOd832[23]];if(Ox142&&element[OxOd832[26]][OxOd832[31]].indexOf(Ox142)!=-1){sel_hor_unit[OxOd832[25]]=i;break ;} ;} ;} ;} ;sel_ver[OxOd832[23]]=element[OxOd832[26]][OxOd832[33]];sel_ver_unit[OxOd832[25]]=0;if(sel_ver[OxOd832[25]]==-1){if(ParseFloatToString(element[OxOd832[26]].backgroundPositionY)){tb_ver[OxOd832[23]]=ParseFloatToString(element[OxOd832[26]].backgroundPositionY);for(var i=0;i<sel_ver_unit[OxOd832[32]][OxOd832[1]];i++){var Ox142=sel_ver_unit[OxOd832[32]][i][OxOd832[23]];if(Ox142&&element[OxOd832[26]][OxOd832[33]].indexOf(Ox142)!=-1){sel_ver_unit[OxOd832[25]]=i;break ;} ;} ;} ;} ;} ;SyncTo=function SyncTo_Background(element){if(tb_image[OxOd832[23]]){element[OxOd832[26]][OxOd832[27]]=OxOd832[34]+tb_image[OxOd832[23]]+OxOd832[35];} else {SetStyle(element.style,OxOd832[36],OxOd832[2]);} ;try{element[OxOd832[26]][OxOd832[28]]=inp_color[OxOd832[23]]||OxOd832[2];} catch(x){element[OxOd832[26]][OxOd832[28]]=OxOd832[2];} ;element[OxOd832[26]][OxOd832[29]]=sel_bgrepeat[OxOd832[23]]||OxOd832[2];element[OxOd832[26]][OxOd832[30]]=sel_bgattach[OxOd832[23]]||OxOd832[2];element[OxOd832[26]][OxOd832[37]]=OxOd832[2];if(sel_hor[OxOd832[25]]>0){element[OxOd832[26]][OxOd832[31]]=sel_hor[OxOd832[23]];} else {if(ParseFloatToString(tb_hor.value)){element[OxOd832[26]][OxOd832[31]]=ParseFloatToString(tb_hor.value)+sel_hor_unit[OxOd832[23]];} else {element[OxOd832[26]][OxOd832[31]]=OxOd832[2];} ;} ;if(sel_ver[OxOd832[25]]>0){element[OxOd832[26]][OxOd832[33]]=sel_ver[OxOd832[23]];} else {if(ParseFloatToString(tb_ver.value)){element[OxOd832[26]][OxOd832[33]]=ParseFloatToString(tb_ver.value)+sel_ver_unit[OxOd832[23]];} else {element[OxOd832[26]][OxOd832[33]]=OxOd832[2];} ;} ;} ;function FixTbImage(){var Ox142=tb_image[OxOd832[23]].replace(/^(\s+)/g,OxOd832[2]).replace(/(\s+)$/g,OxOd832[2]);if(Ox142.substr(0,4).toLowerCase()==OxOd832[34]){Ox142=Ox142.substr(4,Ox142[OxOd832[1]]-4);} ;if(Ox142.substr(Ox142[OxOd832[1]]-1,1)==OxOd832[35]){Ox142=Ox142.substr(0,Ox142[OxOd832[1]]-1);} ;if(Ox142==OxOd832[38]){Ox142=OxOd832[2];} ;tb_image[OxOd832[23]]=Ox142;} ;inp_color[OxOd832[22]]=inp_color_Preview[OxOd832[22]]=function inp_color_onclick(){SelectColor(inp_color,inp_color_Preview);} ;