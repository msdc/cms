var OxO7eda=["zoomcount","wheelDelta","zoom","style","0%","top","hiddenDirectory","hiddenFile","hiddenAlert","hiddenAction","hiddenActionData","This function is disabled in the demo mode.","disabled","[[Disabled]]","[[SpecifyNewFolderName]]","","value","createdir","[[CopyMoveto]]","/","move","copy","[[AreyouSureDelete]]","parentNode","text","isdir","true",".","[[SpecifyNewFileName]]","rename","True","False",":","path","FoldersAndFiles","TR","length","onmouseover","this.style.backgroundColor=\x27#eeeeee\x27;","onmouseout","this.style.backgroundColor=\x27\x27;","nodeName","INPUT","changedir","url","TargetUrl","htmlcode","onload","getElementsByTagName","table","sortable"," ","className","id","rows","cells","innerHTML","\x3Ca href=\x22#\x22 onclick=\x22ts_resortTable(this);return false;\x22\x3E","\x3Cspan class=\x22sortarrow\x22\x3E\x26nbsp;\x3C/span\x3E\x3C/a\x3E","string","undefined","innerText","childNodes","nodeValue","nodeType","span","cellIndex","TABLE","sortdir","down","\x26uarr;","up","\x26darr;","sortbottom","tBodies","sortarrow","\x26nbsp;","20","19","browse_Frame","Image1","FolderDescription","CreateDir","Copy","Move","img_AutoThumbnail","img_ImageEditor","Delete","DoRefresh","name_Cell","size_Cell","op_Cell","divpreview","img_demo","Align","Border","bordercolor","bordercolor_Preview","inp_width","imgLock","inp_height","constrain_prop","HSpace","VSpace","AlternateText","inp_id","longDesc","fieldsetUpload","Button1","Button2","btn_zoom_in","btn_zoom_out","btn_Actualsize","btn_bestfit","img","editor","documentElement","documentMode","clientHeight","scrollHeight","width","265px","appName","Microsoft Internet Explorer","userAgent","MSIE ([0-9]{1,}[.0-9]{0,})","src","src_cetemp","height","vspace","hspace","border","borderColor","backgroundColor","align","alt","longdesc","file","IMG","complete","../images/1x1.gif","?","\x26time=","?time=","0","onmousewheel",".aspx","display","none","Edit","[[ValidID]]","[[ValidColor]]","[[SelectImagetoInsert]]","=\x22","\x22","checked","../Load.ashx?type=image\x26file=locked.gif","../Load.ashx?type=image\x26file=1x1.gif","[[SelectImagetoThumbnail]]","dir","refresh","Thumbnail.aspx?","dialogWidth:310px;dialogHeight:150px;help:no;scroll:no;status:no;resizable:1;","UseStandardDialog","1","\x26Dialog=Standard","setting=","EditorSetting","\x26Theme=","Theme","\x26","DNNArg","[[SelectImagetoEdit]]","[[_CuteEditorResource_]]","../ImageEditor/ImageEditor.aspx?f=","\x26p=","\x26setting=","dialogWidth:676px;dialogHeight:500px;help:no;scroll:no;status:no;resizable:0;","onclick","wrapupPrompt","iepromptfield","body","div","IEPromptBox","promptBlackout","1px solid #b0bec7","#f0f0f0","position","absolute","330px","zIndex","100","\x3Cdiv style=\x22width: 100%; padding-top:3px;background-color: #DCE7EB; font-family: verdana; font-size: 10pt; font-weight: bold; height: 22px; text-align:center; background:url(Load.ashx?type=image\x26file=formbg2.gif) repeat-x left top;\x22\x3E[[InputRequired]]\x3C/div\x3E","\x3Cdiv style=\x22padding: 10px\x22\x3E","\x3CBR\x3E\x3CBR\x3E","\x3Cform action=\x22\x22 onsubmit=\x22return wrapupPrompt()\x22\x3E","\x3Cinput id=\x22iepromptfield\x22 name=\x22iepromptdata\x22 type=text size=46 value=\x22","\x22\x3E","\x3Cbr\x3E\x3Cbr\x3E\x3Ccenter\x3E","\x3Cinput type=\x22submit\x22 value=\x22\x26nbsp;\x26nbsp;\x26nbsp;[[OK]]\x26nbsp;\x26nbsp;\x26nbsp;\x22\x3E","\x26nbsp;\x26nbsp;\x26nbsp;\x26nbsp;\x26nbsp;\x26nbsp;","\x3Cinput type=\x22button\x22 onclick=\x22wrapupPrompt(true)\x22 value=\x22\x26nbsp;[[Cancel]]\x26nbsp;\x22\x3E","\x3C/form\x3E\x3C/div\x3E","100px","left","offsetWidth","px","block","CuteEditor_ColorPicker_ButtonOver(this)"];function OnImageMouseWheel(){var Ox332=Event_GetEvent();var img=Event_GetSrcElement(Ox332);var Ox414=img[OxO7eda[0]]||3;if(Ox332[OxO7eda[1]]>=106){Ox414++;} else {if(Ox332[OxO7eda[1]]<=-106){Ox414--;} ;} ;img[OxO7eda[0]]=Ox414;img[OxO7eda[3]][OxO7eda[2]]=Ox414+OxO7eda[4];return false;} ;function Window_GetDialogTop(Ox1a8){return Ox1a8[OxO7eda[5]];} ;var hiddenDirectory=Window_GetElement(window,OxO7eda[6],true);var hiddenFile=Window_GetElement(window,OxO7eda[7],true);var hiddenAlert=Window_GetElement(window,OxO7eda[8],true);var hiddenAction=Window_GetElement(window,OxO7eda[9],true);var hiddenActionData=Window_GetElement(window,OxO7eda[10],true);function CreateDir_click(){if(isDemoMode){alert(OxO7eda[11]);return false;} ;if(Event_GetSrcElement()[OxO7eda[12]]){alert(OxO7eda[13]);return false;} ;if(Browser_IsIE7()){IEprompt(Ox221,OxO7eda[14],OxO7eda[15]);function Ox221(Ox381){if(Ox381){hiddenActionData[OxO7eda[16]]=Ox381;hiddenAction[OxO7eda[16]]=OxO7eda[17];window.PostBackAction();return true;} else {return false;} ;} ;return Event_CancelEvent();} else {var Ox381=prompt(OxO7eda[14],OxO7eda[15]);if(Ox381){hiddenActionData[OxO7eda[16]]=Ox381;return true;} else {return false;} ;return false;} ;} ;function Move_click(){if(isDemoMode){alert(OxO7eda[11]);return false;} ;if(Event_GetSrcElement()[OxO7eda[12]]){alert(OxO7eda[13]);return false;} ;if(Browser_IsIE7()){IEprompt(Ox221,OxO7eda[18],OxO7eda[19]);function Ox221(Ox381){if(Ox381){hiddenActionData[OxO7eda[16]]=Ox381;hiddenAction[OxO7eda[16]]=OxO7eda[20];window.PostBackAction();return true;} else {return false;} ;} ;return Event_CancelEvent();} else {var Ox381=prompt(OxO7eda[18],OxO7eda[19]);if(Ox381){hiddenActionData[OxO7eda[16]]=Ox381;return true;} else {return false;} ;return false;} ;} ;function Copy_click(){if(isDemoMode){alert(OxO7eda[11]);return false;} ;if(Event_GetSrcElement()[OxO7eda[12]]){alert(OxO7eda[13]);return false;} ;if(Browser_IsIE7()){IEprompt(Ox221,OxO7eda[18],OxO7eda[19]);function Ox221(Ox381){if(Ox381){hiddenActionData[OxO7eda[16]]=Ox381;hiddenAction[OxO7eda[16]]=OxO7eda[21];window.PostBackAction();return true;} else {return false;} ;} ;return Event_CancelEvent();} else {var Ox381=prompt(OxO7eda[18],OxO7eda[19]);if(Ox381){hiddenActionData[OxO7eda[16]]=Ox381;return true;} else {return false;} ;return false;} ;} ;function Delete_click(){if(isDemoMode){alert(OxO7eda[11]);return false;} ;if(Event_GetSrcElement()[OxO7eda[12]]){alert(OxO7eda[13]);return false;} ;return confirm(OxO7eda[22]);} ;function EditImg_click(img){if(isDemoMode){alert(OxO7eda[11]);return false;} ;if(img[OxO7eda[12]]){alert(OxO7eda[13]);return false;} ;var Ox386=img[OxO7eda[23]][OxO7eda[23]];var Ox387=Ox386[OxO7eda[24]];var name;var Ox388;Ox388=Ox386.getAttribute(OxO7eda[25])==OxO7eda[26];if(Browser_IsIE7()){var Oxca;if(Ox388){IEprompt(Ox221,OxO7eda[14],Ox387);} else {var i=Ox387.lastIndexOf(OxO7eda[27]);Oxca=Ox387.substr(i);var Ox12=Ox387.substr(0,Ox387.lastIndexOf(OxO7eda[27]));IEprompt(Ox221,OxO7eda[28],Ox12);} ;function Ox221(Ox381){if(Ox381&&Ox381!=Ox386[OxO7eda[24]]){if(!Ox388){Ox381=Ox381+Oxca;} ;hiddenAction[OxO7eda[16]]=OxO7eda[29];hiddenActionData[OxO7eda[16]]=(Ox388?OxO7eda[30]:OxO7eda[31])+OxO7eda[32]+Ox386[OxO7eda[33]]+OxO7eda[32]+Ox381;window.PostBackAction();} ;} ;} else {if(Ox388){name=prompt(OxO7eda[14],Ox387);} else {var i=Ox387.lastIndexOf(OxO7eda[27]);var Oxca=Ox387.substr(i);var Ox12=Ox387.substr(0,Ox387.lastIndexOf(OxO7eda[27]));name=prompt(OxO7eda[28],Ox12);if(name){name=name+Oxca;} ;} ;if(name&&name!=Ox386[OxO7eda[24]]){hiddenAction[OxO7eda[16]]=OxO7eda[29];hiddenActionData[OxO7eda[16]]=(Ox388?OxO7eda[30]:OxO7eda[31])+OxO7eda[32]+Ox386[OxO7eda[33]]+OxO7eda[32]+name;window.PostBackAction();} ;} ;return Event_CancelEvent();} ;setMouseOver();function setMouseOver(){var FoldersAndFiles=Window_GetElement(window,OxO7eda[34],true);var Ox38b=FoldersAndFiles.getElementsByTagName(OxO7eda[35]);for(var i=1;i<Ox38b[OxO7eda[36]];i++){var Ox386=Ox38b[i];Ox386[OxO7eda[37]]= new Function(OxO7eda[15],OxO7eda[38]);Ox386[OxO7eda[39]]= new Function(OxO7eda[15],OxO7eda[40]);} ;} ;function row_click(Ox386){var Ox388;Ox388=Ox386.getAttribute(OxO7eda[25])==OxO7eda[26];if(Ox388){if(Event_GetSrcElement()[OxO7eda[41]]==OxO7eda[42]){return ;} ;hiddenAction[OxO7eda[16]]=OxO7eda[43];hiddenActionData[OxO7eda[16]]=Ox386.getAttribute(OxO7eda[33]);window.PostBackAction();} else {var Ox109=Ox386.getAttribute(OxO7eda[33]);hiddenFile[OxO7eda[16]]=Ox109;var Ox287=Ox386.getAttribute(OxO7eda[44]);Window_GetElement(window,OxO7eda[45],true)[OxO7eda[16]]=Ox287;var htmlcode=Ox386.getAttribute(OxO7eda[46]);if(htmlcode!=OxO7eda[15]&&htmlcode!=null){do_preview(htmlcode);} else {if(Ox287!=OxO7eda[15]&&Ox287!=null){try{Actualsize();} catch(x){do_preview();} ;} ;} ;} ;} ;function reset_hiddens(){if(hiddenAlert[OxO7eda[16]]){alert(hiddenAlert.value);} ;if(TargetUrl[OxO7eda[16]]!=OxO7eda[15]&&TargetUrl[OxO7eda[16]]!=null){do_preview();} ;hiddenAlert[OxO7eda[16]]=OxO7eda[15];hiddenAction[OxO7eda[16]]=OxO7eda[15];hiddenActionData[OxO7eda[16]]=OxO7eda[15];} ;Event_Attach(window,OxO7eda[47],reset_hiddens);function RequireFileBrowseScript(){} ;Event_Attach(window,OxO7eda[47],sortables_init);var SORT_COLUMN_INDEX;function sortables_init(){if(!document[OxO7eda[48]]){return ;} ;var Ox390=document.getElementsByTagName(OxO7eda[49]);for(var Ox391=0;Ox391<Ox390[OxO7eda[36]];Ox391++){var Ox392=Ox390[Ox391];if(((OxO7eda[51]+Ox392[OxO7eda[52]]+OxO7eda[51]).indexOf(OxO7eda[50])!=-1)&&(Ox392[OxO7eda[53]])){ts_makeSortable(Ox392);} ;} ;} ;function ts_makeSortable(Ox394){if(Ox394[OxO7eda[54]]&&Ox394[OxO7eda[54]][OxO7eda[36]]>0){var Ox395=Ox394[OxO7eda[54]][0];} ;if(!Ox395){return ;} ;for(var i=2;i<4;i++){var Ox396=Ox395[OxO7eda[55]][i];var Ox219=ts_getInnerText(Ox396);Ox396[OxO7eda[56]]=OxO7eda[57]+Ox219+OxO7eda[58];} ;} ;function ts_getInnerText(Ox29){if( typeof Ox29==OxO7eda[59]){return Ox29;} ;if( typeof Ox29==OxO7eda[60]){return Ox29;} ;if(Ox29[OxO7eda[61]]){return Ox29[OxO7eda[61]];} ;var Ox24=OxO7eda[15];var Ox342=Ox29[OxO7eda[62]];var Ox11=Ox342[OxO7eda[36]];for(var i=0;i<Ox11;i++){switch(Ox342[i][OxO7eda[64]]){case 1:Ox24+=ts_getInnerText(Ox342[i]);break ;;case 3:Ox24+=Ox342[i][OxO7eda[63]];break ;;} ;} ;return Ox24;} ;function ts_resortTable(Ox399){var Ox2a5;for(var Ox39a=0;Ox39a<Ox399[OxO7eda[62]][OxO7eda[36]];Ox39a++){if(Ox399[OxO7eda[62]][Ox39a][OxO7eda[41]]&&Ox399[OxO7eda[62]][Ox39a][OxO7eda[41]].toLowerCase()==OxO7eda[65]){Ox2a5=Ox399[OxO7eda[62]][Ox39a];} ;} ;var Ox39b=ts_getInnerText(Ox2a5);var Ox1e4=Ox399[OxO7eda[23]];var Ox39c=Ox1e4[OxO7eda[66]];var Ox394=getParent(Ox1e4,OxO7eda[67]);if(Ox394[OxO7eda[54]][OxO7eda[36]]<=1){return ;} ;var Ox39d=ts_getInnerText(Ox394[OxO7eda[54]][1][OxO7eda[55]][Ox39c]);var Ox39e=ts_sort_caseinsensitive;if(Ox39d.match(/^\d\d[\/-]\d\d[\/-]\d\d\d\d$/)){Ox39e=ts_sort_date;} ;if(Ox39d.match(/^\d\d[\/-]\d\d[\/-]\d\d$/)){Ox39e=ts_sort_date;} ;if(Ox39d.match(/^[?]/)){Ox39e=ts_sort_currency;} ;if(Ox39d.match(/^[\d\.]+$/)){Ox39e=ts_sort_numeric;} ;SORT_COLUMN_INDEX=Ox39c;var Ox395= new Array();var Ox39f= new Array();for(var i=0;i<Ox394[OxO7eda[54]][0][OxO7eda[36]];i++){Ox395[i]=Ox394[OxO7eda[54]][0][i];} ;for(var Ox25=1;Ox25<Ox394[OxO7eda[54]][OxO7eda[36]];Ox25++){Ox39f[Ox25-1]=Ox394[OxO7eda[54]][Ox25];} ;Ox39f.sort(Ox39e);if(Ox2a5.getAttribute(OxO7eda[68])==OxO7eda[69]){var Ox3a0=OxO7eda[70];Ox39f.reverse();Ox2a5.setAttribute(OxO7eda[68],OxO7eda[71]);} else {Ox3a0=OxO7eda[72];Ox2a5.setAttribute(OxO7eda[68],OxO7eda[69]);} ;for(i=0;i<Ox39f[OxO7eda[36]];i++){if(!Ox39f[i][OxO7eda[52]]||(Ox39f[i][OxO7eda[52]]&&(Ox39f[i][OxO7eda[52]].indexOf(OxO7eda[73])==-1))){Ox394[OxO7eda[74]][0].appendChild(Ox39f[i]);} ;} ;for(i=0;i<Ox39f[OxO7eda[36]];i++){if(Ox39f[i][OxO7eda[52]]&&(Ox39f[i][OxO7eda[52]].indexOf(OxO7eda[73])!=-1)){Ox394[OxO7eda[74]][0].appendChild(Ox39f[i]);} ;} ;var Ox3a1=document.getElementsByTagName(OxO7eda[65]);for(var Ox39a=0;Ox39a<Ox3a1[OxO7eda[36]];Ox39a++){if(Ox3a1[Ox39a][OxO7eda[52]]==OxO7eda[75]){if(getParent(Ox3a1[Ox39a],OxO7eda[49])==getParent(Ox399,OxO7eda[49])){Ox3a1[Ox39a][OxO7eda[56]]=OxO7eda[76];} ;} ;} ;Ox2a5[OxO7eda[56]]=Ox3a0;} ;function getParent(Ox29,Ox3a3){if(Ox29==null){return null;} else {if(Ox29[OxO7eda[64]]==1&&Ox29[OxO7eda[41]].toLowerCase()==Ox3a3.toLowerCase()){return Ox29;} else {return getParent(Ox29.parentNode,Ox3a3);} ;} ;} ;function ts_sort_date(Oxee,b){var Ox3a5=ts_getInnerText(Oxee[OxO7eda[55]][SORT_COLUMN_INDEX]);var Ox3a6=ts_getInnerText(b[OxO7eda[55]][SORT_COLUMN_INDEX]);if(Ox3a5[OxO7eda[36]]==10){var Ox3a7=Ox3a5.substr(6,4)+Ox3a5.substr(3,2)+Ox3a5.substr(0,2);} else {var Ox3a8=Ox3a5.substr(6,2);if(parseInt(Ox3a8)<50){Ox3a8=OxO7eda[77]+Ox3a8;} else {Ox3a8=OxO7eda[78]+Ox3a8;} ;var Ox3a7=Ox3a8+Ox3a5.substr(3,2)+Ox3a5.substr(0,2);} ;if(Ox3a6[OxO7eda[36]]==10){var Ox3a9=Ox3a6.substr(6,4)+Ox3a6.substr(3,2)+Ox3a6.substr(0,2);} else {Ox3a8=Ox3a6.substr(6,2);if(parseInt(Ox3a8)<50){Ox3a8=OxO7eda[77]+Ox3a8;} else {Ox3a8=OxO7eda[78]+Ox3a8;} ;var Ox3a9=Ox3a8+Ox3a6.substr(3,2)+Ox3a6.substr(0,2);} ;if(Ox3a7==Ox3a9){return 0;} ;if(Ox3a7<Ox3a9){return -1;} ;return 1;} ;function ts_sort_currency(Oxee,b){var Ox3a5=ts_getInnerText(Oxee[OxO7eda[55]][SORT_COLUMN_INDEX]).replace(/[^0-9.]/g,OxO7eda[15]);var Ox3a6=ts_getInnerText(b[OxO7eda[55]][SORT_COLUMN_INDEX]).replace(/[^0-9.]/g,OxO7eda[15]);return parseFloat(Ox3a5)-parseFloat(Ox3a6);} ;function ts_sort_numeric(Oxee,b){var Ox3a5=parseFloat(ts_getInnerText(Oxee[OxO7eda[55]][SORT_COLUMN_INDEX]));if(isNaN(Ox3a5)){Ox3a5=0;} ;var Ox3a6=parseFloat(ts_getInnerText(b[OxO7eda[55]][SORT_COLUMN_INDEX]));if(isNaN(Ox3a6)){Ox3a6=0;} ;return Ox3a5-Ox3a6;} ;function ts_sort_caseinsensitive(Oxee,b){var Ox3a5=ts_getInnerText(Oxee[OxO7eda[55]][SORT_COLUMN_INDEX]).toLowerCase();var Ox3a6=ts_getInnerText(b[OxO7eda[55]][SORT_COLUMN_INDEX]).toLowerCase();if(Ox3a5==Ox3a6){return 0;} ;if(Ox3a5<Ox3a6){return -1;} ;return 1;} ;function ts_sort_default(Oxee,b){var Ox3a5=ts_getInnerText(Oxee[OxO7eda[55]][SORT_COLUMN_INDEX]);var Ox3a6=ts_getInnerText(b[OxO7eda[55]][SORT_COLUMN_INDEX]);if(Ox3a5==Ox3a6){return 0;} ;if(Ox3a5<Ox3a6){return -1;} ;return 1;} [sortables_init];RequireFileBrowseScript();var browse_Frame=Window_GetElement(window,OxO7eda[79],true);var hiddenDirectory=Window_GetElement(window,OxO7eda[6],true);var hiddenFile=Window_GetElement(window,OxO7eda[7],true);var hiddenAlert=Window_GetElement(window,OxO7eda[8],true);var hiddenAction=Window_GetElement(window,OxO7eda[9],true);var hiddenActionData=Window_GetElement(window,OxO7eda[10],true);var Image1=Window_GetElement(window,OxO7eda[80],true);var FolderDescription=Window_GetElement(window,OxO7eda[81],true);var CreateDir=Window_GetElement(window,OxO7eda[82],true);var Copy=Window_GetElement(window,OxO7eda[83],true);var Move=Window_GetElement(window,OxO7eda[84],true);var img_AutoThumbnail=Window_GetElement(window,OxO7eda[85],true);var img_ImageEditor=Window_GetElement(window,OxO7eda[86],false);var FoldersAndFiles=Window_GetElement(window,OxO7eda[34],true);var Delete=Window_GetElement(window,OxO7eda[87],true);var DoRefresh=Window_GetElement(window,OxO7eda[88],true);var name_Cell=Window_GetElement(window,OxO7eda[89],true);var size_Cell=Window_GetElement(window,OxO7eda[90],true);var op_Cell=Window_GetElement(window,OxO7eda[91],true);var divpreview=Window_GetElement(window,OxO7eda[92],true);var img_demo=Window_GetElement(window,OxO7eda[93],true);var Align=Window_GetElement(window,OxO7eda[94],true);var Border=Window_GetElement(window,OxO7eda[95],true);var bordercolor=Window_GetElement(window,OxO7eda[96],true);var bordercolor_Preview=Window_GetElement(window,OxO7eda[97],true);var inp_width=Window_GetElement(window,OxO7eda[98],true);var imgLock=Window_GetElement(window,OxO7eda[99],true);var inp_height=Window_GetElement(window,OxO7eda[100],true);var constrain_prop=Window_GetElement(window,OxO7eda[101],true);var HSpace=Window_GetElement(window,OxO7eda[102],true);var VSpace=Window_GetElement(window,OxO7eda[103],true);var TargetUrl=Window_GetElement(window,OxO7eda[45],true);var AlternateText=Window_GetElement(window,OxO7eda[104],true);var inp_id=Window_GetElement(window,OxO7eda[105],true);var longDesc=Window_GetElement(window,OxO7eda[106],true);var fieldsetUpload=Window_GetElement(window,OxO7eda[107],true);var Button1=Window_GetElement(window,OxO7eda[108],true);var Button2=Window_GetElement(window,OxO7eda[109],true);var btn_zoom_in=Window_GetElement(window,OxO7eda[110],true);var btn_zoom_out=Window_GetElement(window,OxO7eda[111],true);var btn_Actualsize=Window_GetElement(window,OxO7eda[112],true);var btn_bestfit=Window_GetElement(window,OxO7eda[113],true);var obj=Window_GetDialogArguments(window);var element=obj[OxO7eda[114]];var editor=obj[OxO7eda[115]];var ver=getInternetExplorerVersion();if(ver>-1&&ver<=9.0){var needAdjust=true;if(ver>=8.0&&document[OxO7eda[116]]){if(document[OxO7eda[117]]>7){needAdjust=false;} ;} ;if(needAdjust&&(browse_Frame[OxO7eda[118]]<browse_Frame[OxO7eda[119]])){FoldersAndFiles[OxO7eda[3]][OxO7eda[120]]=OxO7eda[121];} ;} ;function getInternetExplorerVersion(){var Ox3c9=-1;if(navigator[OxO7eda[122]]==OxO7eda[123]){var Ox3ca=navigator[OxO7eda[124]];var Ox295= new RegExp(OxO7eda[125]);if(Ox295.exec(Ox3ca)!=null){Ox3c9=parseFloat(RegExp.$1);} ;} ;return Ox3c9;} ;var src=OxO7eda[15];if(element.getAttribute(OxO7eda[126])){src=element.getAttribute(OxO7eda[126]);} ;if(element.getAttribute(OxO7eda[127])){src=element.getAttribute(OxO7eda[127]);} ;inp_width[OxO7eda[16]]=element[OxO7eda[120]]||OxO7eda[15];inp_height[OxO7eda[16]]=element[OxO7eda[128]]||OxO7eda[15];inp_id[OxO7eda[16]]=element[OxO7eda[53]]||OxO7eda[15];if(element[OxO7eda[129]]<=0){VSpace[OxO7eda[16]]=OxO7eda[15];} else {VSpace[OxO7eda[16]]=element[OxO7eda[129]];} ;if(element[OxO7eda[130]]<=0){HSpace[OxO7eda[16]]=OxO7eda[15];} else {HSpace[OxO7eda[16]]=element[OxO7eda[130]];} ;Border[OxO7eda[16]]=element[OxO7eda[131]]||OxO7eda[15];if(Browser_IsWinIE()){bordercolor[OxO7eda[16]]=element[OxO7eda[3]][OxO7eda[132]];} else {var arr=revertColor(element[OxO7eda[3]].borderColor).split(OxO7eda[51]);bordercolor[OxO7eda[16]]=arr[0];} ;bordercolor[OxO7eda[3]][OxO7eda[133]]=bordercolor[OxO7eda[16]]||OxO7eda[15];bordercolor_Preview[OxO7eda[3]][OxO7eda[133]]=bordercolor[OxO7eda[16]]||OxO7eda[15];Align[OxO7eda[16]]=element[OxO7eda[134]]||OxO7eda[15];AlternateText[OxO7eda[16]]=element[OxO7eda[135]]||OxO7eda[15];longDesc[OxO7eda[16]]=element.getAttribute(OxO7eda[136])||OxO7eda[15];if(TargetUrl[OxO7eda[16]]){Actualsize();} else {if(element&&src){TargetUrl[OxO7eda[16]]=src;} ;} ;var sCheckFlag=OxO7eda[137];function ResetFields(){TargetUrl[OxO7eda[16]]=OxO7eda[15];inp_width[OxO7eda[16]]=OxO7eda[15];inp_height[OxO7eda[16]]=OxO7eda[15];inp_id[OxO7eda[16]]=OxO7eda[15];VSpace[OxO7eda[16]]=OxO7eda[15];HSpace[OxO7eda[16]]=OxO7eda[15];Border[OxO7eda[16]]=OxO7eda[15];bordercolor[OxO7eda[16]]=OxO7eda[15];bordercolor[OxO7eda[3]][OxO7eda[133]]=OxO7eda[15];Align[OxO7eda[16]]=OxO7eda[15];AlternateText[OxO7eda[16]]=OxO7eda[15];longDesc[OxO7eda[16]]=OxO7eda[15];} ;function do_preview(){var Ox231=TargetUrl[OxO7eda[16]];if(Ox231==null){TargetUrl[OxO7eda[16]]=OxO7eda[15];Ox231==OxO7eda[15];} ;if(Ox231!=null&&Ox231!=OxO7eda[15]){var Ox424;var Ox425;var Ox424=document.createElement(OxO7eda[138]);Ox424[OxO7eda[126]]=Ox231;function Ox426(){if(Ox424[OxO7eda[139]]){window.clearInterval(Ox425);var Oxa7= new Date();var Oxa8=Oxa7.getTime();if(Ox231==OxO7eda[15]){Ox231=OxO7eda[140];} ;if(Ox231.indexOf(OxO7eda[141])!=-1){Ox231=Ox231+OxO7eda[142]+Oxa8;} else {Ox231=Ox231+OxO7eda[143]+Oxa8;} ;if(inp_width[OxO7eda[16]]==OxO7eda[144]||inp_width[OxO7eda[16]]==OxO7eda[15]){inp_width[OxO7eda[16]]=Ox424[OxO7eda[120]];inp_height[OxO7eda[16]]=Ox424[OxO7eda[128]];} ;img_demo[OxO7eda[126]]=Ox231;if(Browser_IsWinIE()){Event_Attach(img_demo,OxO7eda[145],OnImageMouseWheel);} ;img_demo[OxO7eda[135]]=AlternateText[OxO7eda[16]];img_demo[OxO7eda[134]]=Align[OxO7eda[16]];img_demo[OxO7eda[120]]=inp_width[OxO7eda[16]];img_demo[OxO7eda[128]]=inp_height[OxO7eda[16]];img_demo[OxO7eda[129]]=VSpace[OxO7eda[16]];img_demo[OxO7eda[130]]=HSpace[OxO7eda[16]];if(parseInt(Border.value)>0){img_demo[OxO7eda[131]]=Border[OxO7eda[16]];} ;if(bordercolor[OxO7eda[16]]!=OxO7eda[15]){img_demo[OxO7eda[3]][OxO7eda[132]]=bordercolor[OxO7eda[16]];} ;Ox231=Ox231.toLowerCase();if(Ox231.indexOf(OxO7eda[146])!=-1){img_AutoThumbnail[OxO7eda[3]][OxO7eda[147]]=OxO7eda[148];if(img_ImageEditor){img_ImageEditor[OxO7eda[3]][OxO7eda[147]]=OxO7eda[148];} ;} ;} ;} ;Ox425=window.setInterval(Ox426,100);} ;} ;function do_insert(){var img=element;img[OxO7eda[126]]=TargetUrl[OxO7eda[16]];if(editor.GetActiveTab()==OxO7eda[149]){img.setAttribute(OxO7eda[127],TargetUrl.value);} ;img[OxO7eda[120]]=inp_width[OxO7eda[16]];img[OxO7eda[128]]=inp_height[OxO7eda[16]];if(img[OxO7eda[3]][OxO7eda[120]]||img[OxO7eda[3]][OxO7eda[128]]){img[OxO7eda[3]][OxO7eda[120]]=inp_width[OxO7eda[16]];img[OxO7eda[3]][OxO7eda[128]]=inp_height[OxO7eda[16]];} ;img[OxO7eda[129]]=VSpace[OxO7eda[16]];img[OxO7eda[130]]=HSpace[OxO7eda[16]];img[OxO7eda[131]]=Border[OxO7eda[16]];var Ox375=/[^a-z\d]/i;if(Ox375.test(inp_id.value)){alert(OxO7eda[150]);return ;} ;img[OxO7eda[53]]=inp_id[OxO7eda[16]];try{img[OxO7eda[3]][OxO7eda[132]]=bordercolor[OxO7eda[16]];} catch(er){alert(OxO7eda[151]);return false;} ;img[OxO7eda[134]]=Align[OxO7eda[16]];img[OxO7eda[135]]=AlternateText[OxO7eda[16]]||OxO7eda[15];img.setAttribute(OxO7eda[106],longDesc.value);if(TargetUrl[OxO7eda[16]]==OxO7eda[15]){alert(OxO7eda[152]);return false;} ;if(img[OxO7eda[120]]==0){img.removeAttribute(OxO7eda[120]);} ;if(img[OxO7eda[128]]==0){img.removeAttribute(OxO7eda[128]);} ;if(!img.getAttribute(OxO7eda[136])){img.removeAttribute(OxO7eda[136]);} ;if(img[OxO7eda[130]]==OxO7eda[15]){img.removeAttribute(OxO7eda[130]);} ;if(img[OxO7eda[129]]==OxO7eda[15]){img.removeAttribute(OxO7eda[129]);} ;if(img[OxO7eda[53]]==OxO7eda[15]){img.removeAttribute(OxO7eda[53]);} ;if(img[OxO7eda[131]]==OxO7eda[15]){img.removeAttribute(OxO7eda[131]);} ;if(img[OxO7eda[134]]==OxO7eda[15]){img.removeAttribute(OxO7eda[134]);} ;if(!img[OxO7eda[23]]){editor.InsertElement(img);} ;Window_CloseDialog(window);} ;function attr(name,Ox4f){if(!Ox4f||Ox4f==OxO7eda[15]){return OxO7eda[15];} ;return OxO7eda[51]+name+OxO7eda[153]+Ox4f+OxO7eda[154];} ;function do_Close(){Window_CloseDialog(window);} ;function Zoom_In(){if(Browser_IsWinIE()){if(divpreview[OxO7eda[3]][OxO7eda[2]]!=0){divpreview[OxO7eda[3]][OxO7eda[2]]*=1.2;} else {divpreview[OxO7eda[3]][OxO7eda[2]]=1.2;} ;} ;} ;function Zoom_Out(){if(Browser_IsWinIE()){if(divpreview[OxO7eda[3]][OxO7eda[2]]!=0){divpreview[OxO7eda[3]][OxO7eda[2]]*=0.8;} else {divpreview[OxO7eda[3]][OxO7eda[2]]=0.8;} ;} ;} ;function BestFit(){var img=img_demo;if(!img){return ;} ;var Ox73=280;var Ox74=290;if(Browser_IsWinIE()){divpreview[OxO7eda[3]][OxO7eda[2]]=1/Math.max(img[OxO7eda[120]]/Ox74,img[OxO7eda[128]]/Ox73);} ;} ;function Actualsize(){inp_width[OxO7eda[16]]=OxO7eda[15];inp_height[OxO7eda[16]]=OxO7eda[15];do_preview();if(Browser_IsWinIE()){divpreview[OxO7eda[3]][OxO7eda[2]]=1;} ;} ;function toggleConstrains(){if(constrain_prop[OxO7eda[155]]){imgLock[OxO7eda[126]]=OxO7eda[156];checkConstrains(OxO7eda[120]);} else {imgLock[OxO7eda[126]]=OxO7eda[157];} ;} ;var checkingConstrains=false;function checkConstrains(Ox7a){if(checkingConstrains){return ;} ;checkingConstrains=true;try{if(constrain_prop[OxO7eda[155]]){var Ox7d=document.createElement(OxO7eda[138]);Ox7d[OxO7eda[126]]=TargetUrl[OxO7eda[16]];var Ox427=Ox7d[OxO7eda[120]];var Ox428=Ox7d[OxO7eda[128]];if((Ox427>0)&&(Ox428>0)){var Ox74=inp_width[OxO7eda[16]];var Ox73=inp_height[OxO7eda[16]];if(Ox7a==OxO7eda[120]){if(Ox74[OxO7eda[36]]==0||isNaN(Ox74)){inp_width[OxO7eda[16]]=OxO7eda[15];inp_height[OxO7eda[16]]=OxO7eda[15];} else {Ox73=parseInt(Ox74*Ox428/Ox427);inp_height[OxO7eda[16]]=Ox73;} ;} ;if(Ox7a==OxO7eda[128]){if(Ox73[OxO7eda[36]]==0||isNaN(Ox73)){inp_width[OxO7eda[16]]=OxO7eda[15];inp_height[OxO7eda[16]]=OxO7eda[15];} else {Ox74=parseInt(Ox73*Ox427/Ox428);inp_width[OxO7eda[16]]=Ox74;} ;} ;} ;} ;do_preview();} finally{checkingConstrains=false;} ;} ;function AutoThumbnail(){if(TargetUrl[OxO7eda[16]]==OxO7eda[15]){alert(OxO7eda[158]);return false;} ;var obj= new Object();obj[OxO7eda[126]]=TargetUrl[OxO7eda[16]];obj[OxO7eda[159]]=FolderDescription[OxO7eda[56]]+OxO7eda[15];function Ox35c(Ox20a){if(Ox20a){TargetUrl[OxO7eda[16]]=Ox20a;hiddenAction[OxO7eda[16]]=OxO7eda[160];window.PostBackAction();} ;} ;editor.SetNextDialogWindow(window);editor.ShowDialog(Ox35c,OxO7eda[161]+GetDialogQueryString(),obj,OxO7eda[162]);} ;function GetDialogQueryString(){var Ox120=OxO7eda[15];if(editor.GetScriptProperty(OxO7eda[163])==OxO7eda[164]){Ox120=OxO7eda[165];} ;return OxO7eda[166]+editor.GetScriptProperty(OxO7eda[167])+OxO7eda[168]+editor.GetScriptProperty(OxO7eda[169])+Ox120+OxO7eda[170]+editor.GetScriptProperty(OxO7eda[171]);} ;function ImageEditor(){var src=TargetUrl[OxO7eda[16]];if(src==OxO7eda[15]){alert(OxO7eda[172]);return false;} ;if(src.charAt(0)!=OxO7eda[19]){return ;} ;var img=document.createElement(OxO7eda[138]);img[OxO7eda[126]]=src;var p=OxO7eda[173];function Ox35c(arr){TargetUrl[OxO7eda[16]]=src;do_preview();} ;editor.SetNextDialogWindow(window);editor.ShowDialog(Ox35c,OxO7eda[174]+src+OxO7eda[175]+p+OxO7eda[176]+editor.GetScriptProperty(OxO7eda[167]),img,OxO7eda[177]);} ;bordercolor[OxO7eda[178]]=bordercolor_Preview[OxO7eda[178]]=function bordercolor_onclick(){SelectColor(bordercolor,bordercolor_Preview);} ;if(!Browser_IsWinIE()){img_ImageEditor[OxO7eda[3]][OxO7eda[147]]=btn_zoom_in[OxO7eda[3]][OxO7eda[147]]=btn_zoom_out[OxO7eda[3]][OxO7eda[147]]=btn_bestfit[OxO7eda[3]][OxO7eda[147]]=btn_Actualsize[OxO7eda[3]][OxO7eda[147]]=OxO7eda[148];} ;if(Browser_IsIE7()){var _dialogPromptID=null;function IEprompt(Ox221,Ox222,Ox223){that=this;this[OxO7eda[179]]=function (Ox224){val=document.getElementById(OxO7eda[180])[OxO7eda[16]];_dialogPromptID[OxO7eda[3]][OxO7eda[147]]=OxO7eda[148];document.getElementById(OxO7eda[180])[OxO7eda[16]]=OxO7eda[15];if(Ox224){val=OxO7eda[15];} ;Ox221(val);return false;} ;if(Ox223==undefined){Ox223=OxO7eda[15];} ;if(_dialogPromptID==null){var Ox225=document.getElementsByTagName(OxO7eda[181])[0];tnode=document.createElement(OxO7eda[182]);tnode[OxO7eda[53]]=OxO7eda[183];Ox225.appendChild(tnode);_dialogPromptID=document.getElementById(OxO7eda[183]);tnode=document.createElement(OxO7eda[182]);tnode[OxO7eda[53]]=OxO7eda[184];Ox225.appendChild(tnode);_dialogPromptID[OxO7eda[3]][OxO7eda[131]]=OxO7eda[185];_dialogPromptID[OxO7eda[3]][OxO7eda[133]]=OxO7eda[186];_dialogPromptID[OxO7eda[3]][OxO7eda[187]]=OxO7eda[188];_dialogPromptID[OxO7eda[3]][OxO7eda[120]]=OxO7eda[189];_dialogPromptID[OxO7eda[3]][OxO7eda[190]]=OxO7eda[191];} ;var Ox226=OxO7eda[192];Ox226+=OxO7eda[193]+Ox222+OxO7eda[194];Ox226+=OxO7eda[195];Ox226+=OxO7eda[196]+Ox223+OxO7eda[197];Ox226+=OxO7eda[198];Ox226+=OxO7eda[199];Ox226+=OxO7eda[200];Ox226+=OxO7eda[201];Ox226+=OxO7eda[202];_dialogPromptID[OxO7eda[56]]=Ox226;_dialogPromptID[OxO7eda[3]][OxO7eda[5]]=OxO7eda[203];_dialogPromptID[OxO7eda[3]][OxO7eda[204]]=parseInt((document[OxO7eda[181]][OxO7eda[205]]-315)/2)+OxO7eda[206];_dialogPromptID[OxO7eda[3]][OxO7eda[147]]=OxO7eda[207];var Ox227=document.getElementById(OxO7eda[180]);try{var Ox228=Ox227.createTextRange();Ox228.collapse(false);Ox228.select();} catch(x){Ox227.focus();} ;} ;} ;if(CreateDir){CreateDir[OxO7eda[37]]= new Function(OxO7eda[208]);} ;if(Copy){Copy[OxO7eda[37]]= new Function(OxO7eda[208]);} ;if(Move){Move[OxO7eda[37]]= new Function(OxO7eda[208]);} ;if(Delete){Delete[OxO7eda[37]]= new Function(OxO7eda[208]);} ;if(DoRefresh){DoRefresh[OxO7eda[37]]= new Function(OxO7eda[208]);} ;if(btn_zoom_in){btn_zoom_in[OxO7eda[37]]= new Function(OxO7eda[208]);} ;if(btn_zoom_out){btn_zoom_out[OxO7eda[37]]= new Function(OxO7eda[208]);} ;if(btn_Actualsize){btn_Actualsize[OxO7eda[37]]= new Function(OxO7eda[208]);} ;if(img_ImageEditor){img_ImageEditor[OxO7eda[37]]= new Function(OxO7eda[208]);} ;if(btn_bestfit){btn_bestfit[OxO7eda[37]]= new Function(OxO7eda[208]);} ;if(img_AutoThumbnail){img_AutoThumbnail[OxO7eda[37]]= new Function(OxO7eda[208]);} ;