var OxO71a6=["ua","userAgent","isOpera","opera","isSafari","safari","isGecko","gecko","isWinIE","msie","compatMode","document","CSS1Compat","undefined","Microsoft.XMLHTTP","readyState","onreadystatechange","","length","all","childNodes","nodeType","\x0D\x0A","caller","onchange","oninitialized","command","commandui","commandvalue","returnValue","oncommand","string","_fireEventFunction","event","parentNode","_IsCuteEditor","True","readOnly","_IsRichDropDown","null","value","selectedIndex","nodeName","TR","cells","display","style","nextSibling","innerHTML","\x3Cimg src=\x22","/Load.ashx?type=image\x26file=t-minus.gif\x22\x3E","onclick","CuteEditor_CollapseTreeDropDownItem(this,\x22","\x22)","onmousedown","none","/Load.ashx?type=image\x26file=t-plus.gif\x22\x3E","CuteEditor_ExpandTreeDropDownItem(this,\x22","contains","UNSELECTABLE","on","tabIndex","-1","//TODO: event not found? throw error ?","contentWindow","contentDocument","parentWindow","id","frames","frameElement","//TODO:frame contentWindow not found?","preventDefault","arguments","parent","top","opener","srcElement","target","//TODO: srcElement not found? throw error ?","fromElement","relatedTarget","toElement","keyCode","clientX","clientY","offsetX","offsetY","button","ctrlKey","altKey","shiftKey","cancelBubble","stopPropagation","CuteEditor_GetEditor(this).ExecImageCommand(this.getAttribute(\x27Command\x27),this.getAttribute(\x27CommandUI\x27),this.getAttribute(\x27CommandArgument\x27),this)","CuteEditor_GetEditor(this).PostBack(this.getAttribute(\x27Command\x27))","this.onmouseout();CuteEditor_GetEditor(this).DropMenu(this.getAttribute(\x27Group\x27),this)","ResourceDir","Theme","/Load.ashx?type=theme\x26theme=","\x26file=all.png","/Images/blank2020.gif","IMG","alt","title","Command","Group","ThemeIndex","width","20px","height","src","backgroundImage","url(",")","backgroundPosition","0 -","px","onload","className","separator","CuteEditorButton","onmouseover","CuteEditor_ButtonCommandOver(this)","onmouseout","CuteEditor_ButtonCommandOut(this)","CuteEditor_ButtonCommandDown(this)","onmouseup","CuteEditor_ButtonCommandUp(this)","oncontextmenu","ondragstart","PostBack","ondblclick","_ToolBarID","_CodeViewToolBarID","_FrameID"," CuteEditorFrame"," CuteEditorToolbar","ActiveTab","Edit","Code","View","buttonInitialized","isover","CuteEditorButtonOver","CuteEditorButtonDown","CuteEditorDown","border","solid 1px #0A246A","backgroundColor","#b6bdd2","padding","1px","solid 1px #f5f5f4","inset 1px","IsCommandDisabled","CuteEditorButtonDisabled","IsCommandActive","CuteEditorButtonActive","cmd_fromfullpage","(","href","location",",DanaInfo=",",","+","scriptProperties","GetScriptProperty","/Load.ashx?type=scripts\x26file=Opera_Implementation\x26culture=","Culture","CuteEditorImplementation","function","POST","\x26getModified=1\x26_temp=","status","responseText","GET","\x26modified=","Failed to load impl code!","block","contentEditable","body"," \x3Cbr /\x3E ","designMode","cursor","InitializeCode","CuteEditorInitialize"];var _Browser_TypeInfo=null;function Browser__InitType(){if(_Browser_TypeInfo!=null){return ;} ;var Ox4={};Ox4[OxO71a6[0]]=navigator[OxO71a6[1]].toLowerCase();Ox4[OxO71a6[2]]=(Ox4[OxO71a6[0]].indexOf(OxO71a6[3])>-1);Ox4[OxO71a6[4]]=(Ox4[OxO71a6[0]].indexOf(OxO71a6[5])>-1);Ox4[OxO71a6[6]]=(!Ox4[OxO71a6[2]]&&Ox4[OxO71a6[0]].indexOf(OxO71a6[7])>-1);Ox4[OxO71a6[8]]=(!Ox4[OxO71a6[2]]&&Ox4[OxO71a6[0]].indexOf(OxO71a6[9])>-1);_Browser_TypeInfo=Ox4;} ;Browser__InitType();function Browser_IsWinIE(){return _Browser_TypeInfo[OxO71a6[8]];} ;function Browser_IsGecko(){return _Browser_TypeInfo[OxO71a6[6]];} ;function Browser_IsOpera(){return _Browser_TypeInfo[OxO71a6[2]];} ;function Browser_IsSafari(){return _Browser_TypeInfo[OxO71a6[4]];} ;function Browser_UseIESelection(){return _Browser_TypeInfo[OxO71a6[8]];} ;function Browser_IsCSS1Compat(){return window[OxO71a6[11]][OxO71a6[10]]==OxO71a6[12];} ;function CreateXMLHttpRequest(){try{if( typeof (XMLHttpRequest)!=OxO71a6[13]){return  new XMLHttpRequest();} ;if( typeof (ActiveXObject)!=OxO71a6[13]){return  new ActiveXObject(OxO71a6[14]);} ;} catch(x){return null;} ;} ;function LoadXMLAsync(Oxa37,Ox287,Ox234,Oxa38){var Oxe7=CreateXMLHttpRequest();function Oxa39(){if(Oxe7[OxO71a6[15]]!=4){return ;} ;Oxe7[OxO71a6[16]]= new Function();var Ox28f=Oxe7;Oxe7=null;Ox234(Ox28f);} ;Oxe7[OxO71a6[16]]=Oxa39;Oxe7.open(Oxa37,Ox287,true);Oxe7.send(Oxa38||OxO71a6[17]);} ;function Element_GetAllElements(p){var arr=[];if(Browser_IsWinIE()){for(var i=0;i<p[OxO71a6[19]][OxO71a6[18]];i++){arr.push(p[OxO71a6[19]].item(i));} ;return arr;} ;Ox241(p);function Ox241(Ox29){var Ox217=Ox29[OxO71a6[20]];var Ox11=Ox217[OxO71a6[18]];for(var i=0;i<Ox11;i++){var Ox27=Ox217.item(i);if(Ox27[OxO71a6[21]]!=1){continue ;} ;arr.push(Ox27);Ox241(Ox27);} ;} ;return arr;} ;var __ISDEBUG=false;function Debug_Todo(msg){if(!__ISDEBUG){return ;} ;throw ( new Error(msg+OxO71a6[22]+Debug_Todo[OxO71a6[23]]));} ;function Window_GetElement(Ox1a8,Ox9a,Ox23f){var Ox29=Ox1a8[OxO71a6[11]].getElementById(Ox9a);if(Ox29){return Ox29;} ;var Ox31=Ox1a8[OxO71a6[11]].getElementsByName(Ox9a);if(Ox31[OxO71a6[18]]>0){return Ox31.item(0);} ;return null;} ;function CuteEditor_AddMainMenuItems(Ox667){} ;function CuteEditor_AddDropMenuItems(Ox667,Ox66e){} ;function CuteEditor_AddTagMenuItems(Ox667,Ox670){} ;function CuteEditor_AddVerbMenuItems(Ox667,Ox670){} ;function CuteEditor_OnInitialized(editor){} ;function CuteEditor_OnCommand(editor,Ox4d,Ox4e,Ox4f){} ;function CuteEditor_OnChange(editor){} ;function CuteEditor_FilterCode(editor,Ox26a){return Ox26a;} ;function CuteEditor_FilterHTML(editor,Ox282){return Ox282;} ;function CuteEditor_FireChange(editor){window.CuteEditor_OnChange(editor);CuteEditor_FireEvent(editor,OxO71a6[24],null);} ;function CuteEditor_FireInitialized(editor){window.CuteEditor_OnInitialized(editor);CuteEditor_FireEvent(editor,OxO71a6[25],null);} ;function CuteEditor_FireCommand(editor,Ox4d,Ox4e,Ox4f){var Ox13e=window.CuteEditor_OnCommand(editor,Ox4d,Ox4e,Ox4f);if(Ox13e==true){return true;} ;var Ox679={};Ox679[OxO71a6[26]]=Ox4d;Ox679[OxO71a6[27]]=Ox4e;Ox679[OxO71a6[28]]=Ox4f;Ox679[OxO71a6[29]]=true;CuteEditor_FireEvent(editor,OxO71a6[30],Ox679);if(Ox679[OxO71a6[29]]==false){return true;} ;} ;function CuteEditor_FireEvent(editor,Ox67b,Ox67c){if(Ox67c==null){Ox67c={};} ;var Ox67d=editor.getAttribute(Ox67b);if(Ox67d){if( typeof (Ox67d)==OxO71a6[31]){editor[OxO71a6[32]]= new Function(OxO71a6[33],Ox67d);} else {editor[OxO71a6[32]]=Ox67d;} ;editor._fireEventFunction(Ox67c);} ;} ;function CuteEditor_GetEditor(element){for(var Ox43=element;Ox43!=null;Ox43=Ox43[OxO71a6[34]]){if(Ox43.getAttribute(OxO71a6[35])==OxO71a6[36]){return Ox43;} ;} ;return null;} ;function CuteEditor_DropDownCommand(element,Oxa3b){var editor=CuteEditor_GetEditor(element);if(editor[OxO71a6[37]]){return ;} ;if(element.getAttribute(OxO71a6[38])==OxO71a6[36]){var Ox142=element.GetValue();if(Ox142==OxO71a6[39]){Ox142=OxO71a6[17];} ;var Ox201=element.GetText();if(Ox201==OxO71a6[39]){Ox201=OxO71a6[17];} ;element.SetSelectedIndex(0);editor.ExecCommand(Oxa3b,false,Ox142,Ox201);} else {if(element[OxO71a6[40]]){var Ox142=element[OxO71a6[40]];if(Ox142==OxO71a6[39]){Ox142=OxO71a6[17];} ;element[OxO71a6[41]]=0;editor.ExecCommand(Oxa3b,false,Ox142,Ox201);} else {element[OxO71a6[41]]=0;} ;} ;editor.FocusDocument();} ;function CuteEditor_ExpandTreeDropDownItem(src,Ox73d){var Oxba=null;while(src!=null){if(src[OxO71a6[42]]==OxO71a6[43]){Oxba=src;break ;} ;src=src[OxO71a6[34]];} ;var Ox1e4=Oxba[OxO71a6[44]].item(0);Oxba[OxO71a6[47]][OxO71a6[46]][OxO71a6[45]]=OxO71a6[17];Ox1e4[OxO71a6[48]]=OxO71a6[49]+Ox73d+OxO71a6[50];Oxba[OxO71a6[51]]= new Function(OxO71a6[52]+Ox73d+OxO71a6[53]);Oxba[OxO71a6[54]]= new Function(OxO71a6[52]+Ox73d+OxO71a6[53]);} ;function CuteEditor_CollapseTreeDropDownItem(src,Ox73d){var Oxba=null;while(src!=null){if(src[OxO71a6[42]]==OxO71a6[43]){Oxba=src;break ;} ;src=src[OxO71a6[34]];} ;var Ox1e4=Oxba[OxO71a6[44]].item(0);Oxba[OxO71a6[47]][OxO71a6[46]][OxO71a6[45]]=OxO71a6[55];Ox1e4[OxO71a6[48]]=OxO71a6[49]+Ox73d+OxO71a6[56];Oxba[OxO71a6[51]]= new Function(OxO71a6[57]+Ox73d+OxO71a6[53]);Oxba[OxO71a6[54]]= new Function(OxO71a6[57]+Ox73d+OxO71a6[53]);} ;function Element_Contains(element,Ox183){if(!Browser_IsOpera()){if(element[OxO71a6[58]]){return element.contains(Ox183);} ;} ;for(;Ox183!=null;Ox183=Ox183[OxO71a6[34]]){if(element==Ox183){return true;} ;} ;return false;} ;function Element_SetUnselectable(element){element.setAttribute(OxO71a6[59],OxO71a6[60]);element.setAttribute(OxO71a6[61],OxO71a6[62]);var arr=Element_GetAllElements(element);var len=arr[OxO71a6[18]];if(!len){return ;} ;for(var i=0;i<len;i++){arr[i].setAttribute(OxO71a6[59],OxO71a6[60]);arr[i].setAttribute(OxO71a6[61],OxO71a6[62]);} ;} ;function Event_GetEvent(Ox244){Ox244=Event_FindEvent(Ox244);if(Ox244==null){Debug_Todo(OxO71a6[63]);} ;return Ox244;} ;function Frame_GetContentWindow(Ox348){if(Ox348[OxO71a6[64]]){return Ox348[OxO71a6[64]];} ;if(Ox348[OxO71a6[65]]){if(Ox348[OxO71a6[65]][OxO71a6[66]]){return Ox348[OxO71a6[65]][OxO71a6[66]];} ;} ;var Ox1a8;if(Ox348[OxO71a6[67]]){Ox1a8=window[OxO71a6[68]][Ox348[OxO71a6[67]]];if(Ox1a8){return Ox1a8;} ;} ;var len=window[OxO71a6[68]][OxO71a6[18]];for(var i=0;i<len;i++){Ox1a8=window[OxO71a6[68]][i];if(Ox1a8[OxO71a6[69]]==Ox348){return Ox1a8;} ;if(Ox1a8[OxO71a6[11]]==Ox348[OxO71a6[65]]){return Ox1a8;} ;} ;Debug_Todo(OxO71a6[70]);} ;function Array_IndexOf(arr,Ox246){for(var i=0;i<arr[OxO71a6[18]];i++){if(arr[i]==Ox246){return i;} ;} ;return -1;} ;function Array_Contains(arr,Ox246){return Array_IndexOf(arr,Ox246)!=-1;} ;function Event_FindEvent(Ox244){if(Ox244&&Ox244[OxO71a6[71]]){return Ox244;} ;if(Browser_IsGecko()){return Event_FindEvent_FindEventFromCallers();} else {if(window[OxO71a6[33]]){return window[OxO71a6[33]];} ;return Event_FindEvent_FindEventFromWindows();} ;return null;} ;function Event_FindEvent_FindEventFromCallers(){var Ox18f=Event_GetEvent[OxO71a6[23]];for(var i=0;i<100;i++){if(!Ox18f){break ;} ;var Ox244=Ox18f[OxO71a6[72]][0];if(Ox244&&Ox244[OxO71a6[71]]){return Ox244;} ;Ox18f=Ox18f[OxO71a6[23]];} ;} ;function Event_FindEvent_FindEventFromWindows(){var arr=[];return Ox24d(window);function Ox24d(Ox1a8){if(Ox1a8==null){return null;} ;if(Ox1a8[OxO71a6[33]]){return Ox1a8[OxO71a6[33]];} ;if(Array_Contains(arr,Ox1a8)){return null;} ;arr.push(Ox1a8);var Ox24e=[];if(Ox1a8[OxO71a6[73]]!=Ox1a8){Ox24e.push(Ox1a8.parent);} ;if(Ox1a8[OxO71a6[74]]!=Ox1a8[OxO71a6[73]]){Ox24e.push(Ox1a8.top);} ;if(Ox1a8[OxO71a6[75]]){Ox24e.push(Ox1a8.opener);} ;for(var i=0;i<Ox1a8[OxO71a6[68]][OxO71a6[18]];i++){Ox24e.push(Ox1a8[OxO71a6[68]][i]);} ;for(var i=0;i<Ox24e[OxO71a6[18]];i++){try{var Ox244=Ox24d(Ox24e[i]);if(Ox244){return Ox244;} ;} catch(x){} ;} ;return null;} ;} ;function Event_GetSrcElement(Ox244){Ox244=Event_GetEvent(Ox244);if(Ox244[OxO71a6[76]]){return Ox244[OxO71a6[76]];} ;if(Ox244[OxO71a6[77]]){return Ox244[OxO71a6[77]];} ;Debug_Todo(OxO71a6[78]);return null;} ;function Event_GetFromElement(Ox244){Ox244=Event_GetEvent(Ox244);if(Ox244[OxO71a6[79]]){return Ox244[OxO71a6[79]];} ;if(Ox244[OxO71a6[80]]){return Ox244[OxO71a6[80]];} ;return null;} ;function Event_GetToElement(Ox244){Ox244=Event_GetEvent(Ox244);if(Ox244[OxO71a6[81]]){return Ox244[OxO71a6[81]];} ;if(Ox244[OxO71a6[80]]){return Ox244[OxO71a6[80]];} ;return null;} ;function Event_GetKeyCode(Ox244){Ox244=Event_GetEvent(Ox244);return Ox244[OxO71a6[82]];} ;function Event_GetClientX(Ox244){Ox244=Event_GetEvent(Ox244);return Ox244[OxO71a6[83]];} ;function Event_GetClientY(Ox244){Ox244=Event_GetEvent(Ox244);return Ox244[OxO71a6[84]];} ;function Event_GetOffsetX(Ox244){Ox244=Event_GetEvent(Ox244);return Ox244[OxO71a6[85]];} ;function Event_GetOffsetY(Ox244){Ox244=Event_GetEvent(Ox244);return Ox244[OxO71a6[86]];} ;function Event_IsLeftButton(Ox244){Ox244=Event_GetEvent(Ox244);if(Browser_IsWinIE()){return Ox244[OxO71a6[87]]==1;} ;if(Browser_IsGecko()){return Ox244[OxO71a6[87]]==0;} ;return Ox244[OxO71a6[87]]==0;} ;function Event_IsCtrlKey(Ox244){Ox244=Event_GetEvent(Ox244);return Ox244[OxO71a6[88]];} ;function Event_IsAltKey(Ox244){Ox244=Event_GetEvent(Ox244);return Ox244[OxO71a6[89]];} ;function Event_IsShiftKey(Ox244){Ox244=Event_GetEvent(Ox244);return Ox244[OxO71a6[90]];} ;function Event_PreventDefault(Ox244){Ox244=Event_GetEvent(Ox244);Ox244[OxO71a6[29]]=false;if(Ox244[OxO71a6[71]]){Ox244.preventDefault();} ;} ;function Event_CancelBubble(Ox244){Ox244=Event_GetEvent(Ox244);Ox244[OxO71a6[91]]=true;if(Ox244[OxO71a6[92]]){Ox244.stopPropagation();} ;return false;} ;function Event_CancelEvent(Ox244){Ox244=Event_GetEvent(Ox244);Event_PreventDefault(Ox244);return Event_CancelBubble(Ox244);} ;function CuteEditor_BasicInitialize(editor){var Ox158=Browser_IsOpera();var Ox706= new Function(OxO71a6[93]);var Oxa3f= new Function(OxO71a6[94]);var Oxa40= new Function(OxO71a6[95]);var Oxa41=editor.GetScriptProperty(OxO71a6[96]);var Oxa42=editor.GetScriptProperty(OxO71a6[97]);var Oxa43=Oxa41+OxO71a6[98]+Oxa42+OxO71a6[99];var Oxa44=Oxa41+OxO71a6[100];var images=editor.getElementsByTagName(OxO71a6[101]);var len=images[OxO71a6[18]];for(var i=0;i<len;i++){var img=images[i];if(img.getAttribute(OxO71a6[102])&&!img.getAttribute(OxO71a6[103])){img.setAttribute(OxO71a6[103],img.getAttribute(OxO71a6[102]));} ;var Ox135=img.getAttribute(OxO71a6[104]);var Ox66e=img.getAttribute(OxO71a6[105]);var Oxa45=img.getAttribute(OxO71a6[106]);if(parseInt(Oxa45)>=0){img[OxO71a6[46]][OxO71a6[107]]=OxO71a6[108];img[OxO71a6[46]][OxO71a6[109]]=OxO71a6[108];img[OxO71a6[110]]=Oxa44;img[OxO71a6[46]][OxO71a6[111]]=OxO71a6[112]+Oxa43+OxO71a6[113];img[OxO71a6[46]][OxO71a6[114]]=OxO71a6[115]+(Oxa45*20)+OxO71a6[116];img[OxO71a6[46]][OxO71a6[45]]=OxO71a6[17];} ;if(!Ox135&&!Ox66e){if(Ox158){img[OxO71a6[117]]=CuteEditor_OperaHandleImageLoaded;} ;continue ;} ;if(img[OxO71a6[118]]!=OxO71a6[119]){img[OxO71a6[118]]=OxO71a6[120];img[OxO71a6[121]]= new Function(OxO71a6[122]);img[OxO71a6[123]]= new Function(OxO71a6[124]);img[OxO71a6[54]]= new Function(OxO71a6[125]);img[OxO71a6[126]]= new Function(OxO71a6[127]);} ;if(!img[OxO71a6[128]]){img[OxO71a6[128]]=Event_CancelEvent;} ;if(!img[OxO71a6[129]]){img[OxO71a6[129]]=Event_CancelEvent;} ;if(Ox135){var Ox18f=img.getAttribute(OxO71a6[130])==OxO71a6[36]?Oxa3f:Ox706;if(img[OxO71a6[51]]==null){img[OxO71a6[51]]=Ox18f;} ;if(img[OxO71a6[131]]==null){img[OxO71a6[131]]=Ox18f;} ;} else {if(Ox66e){if(img[OxO71a6[51]]==null){img[OxO71a6[51]]=Oxa40;} ;} ;} ;} ;var Ox773=Window_GetElement(window,editor.GetScriptProperty(OxO71a6[132]),true);var Ox774=Window_GetElement(window,editor.GetScriptProperty(OxO71a6[133]),true);var Ox76f=Window_GetElement(window,editor.GetScriptProperty(OxO71a6[134]),true);Ox76f[OxO71a6[118]]+=OxO71a6[135];Ox773[OxO71a6[118]]+=OxO71a6[136];Ox774[OxO71a6[118]]+=OxO71a6[136];Element_SetUnselectable(Ox773);Element_SetUnselectable(Ox774);var Ox7f9=editor.GetScriptProperty(OxO71a6[137]);switch(Ox7f9){case OxO71a6[138]:Ox773[OxO71a6[46]][OxO71a6[45]]=OxO71a6[17];break ;;case OxO71a6[139]:Ox774[OxO71a6[46]][OxO71a6[45]]=OxO71a6[17];break ;;case OxO71a6[140]:break ;;} ;} ;function CuteEditor_OperaHandleImageLoaded(){var img=this;if(img[OxO71a6[46]][OxO71a6[45]]){img[OxO71a6[46]][OxO71a6[45]]=OxO71a6[55];setTimeout(function Oxa47(){img[OxO71a6[46]][OxO71a6[45]]=OxO71a6[17];} ,1);} ;} ;function CuteEditor_ButtonOver(element){if(!element[OxO71a6[141]]){element[OxO71a6[128]]=Event_CancelEvent;element[OxO71a6[123]]=CuteEditor_ButtonOut;element[OxO71a6[54]]=CuteEditor_ButtonDown;element[OxO71a6[126]]=CuteEditor_ButtonUp;Element_SetUnselectable(element);element[OxO71a6[141]]=true;} ;element[OxO71a6[142]]=true;element[OxO71a6[118]]=OxO71a6[143];} ;function CuteEditor_ButtonOut(){var element=this;element[OxO71a6[118]]=OxO71a6[120];element[OxO71a6[142]]=false;} ;function CuteEditor_ButtonDown(){if(!Event_IsLeftButton()){return ;} ;var element=this;element[OxO71a6[118]]=OxO71a6[144];} ;function CuteEditor_ButtonUp(){if(!Event_IsLeftButton()){return ;} ;var element=this;if(element[OxO71a6[142]]){element[OxO71a6[118]]=OxO71a6[143];} else {element[OxO71a6[118]]=OxO71a6[145];} ;} ;function CuteEditor_ColorPicker_ButtonOver(element){if(!element[OxO71a6[141]]){element[OxO71a6[128]]=Event_CancelEvent;element[OxO71a6[123]]=CuteEditor_ColorPicker_ButtonOut;element[OxO71a6[54]]=CuteEditor_ColorPicker_ButtonDown;Element_SetUnselectable(element);element[OxO71a6[141]]=true;} ;element[OxO71a6[142]]=true;element[OxO71a6[46]][OxO71a6[146]]=OxO71a6[147];element[OxO71a6[46]][OxO71a6[148]]=OxO71a6[149];element[OxO71a6[46]][OxO71a6[150]]=OxO71a6[151];} ;function CuteEditor_ColorPicker_ButtonOut(){var element=this;element[OxO71a6[142]]=false;element[OxO71a6[46]][OxO71a6[146]]=OxO71a6[152];element[OxO71a6[46]][OxO71a6[148]]=OxO71a6[17];element[OxO71a6[46]][OxO71a6[150]]=OxO71a6[151];} ;function CuteEditor_ColorPicker_ButtonDown(){var element=this;element[OxO71a6[46]][OxO71a6[146]]=OxO71a6[153];element[OxO71a6[46]][OxO71a6[148]]=OxO71a6[17];element[OxO71a6[46]][OxO71a6[150]]=OxO71a6[151];} ;function CuteEditor_ButtonCommandOver(element){element[OxO71a6[142]]=true;if(element[OxO71a6[154]]){element[OxO71a6[118]]=OxO71a6[155];} else {element[OxO71a6[118]]=OxO71a6[143];} ;} ;function CuteEditor_ButtonCommandOut(element){element[OxO71a6[142]]=false;if(element[OxO71a6[156]]){element[OxO71a6[118]]=OxO71a6[157];} else {if(element[OxO71a6[154]]){element[OxO71a6[118]]=OxO71a6[155];} else {if(element[OxO71a6[67]]!=OxO71a6[158]){element[OxO71a6[118]]=OxO71a6[120];} ;} ;} ;} ;function CuteEditor_ButtonCommandDown(element){if(!Event_IsLeftButton()){return ;} ;element[OxO71a6[118]]=OxO71a6[144];} ;function CuteEditor_ButtonCommandUp(element){if(!Event_IsLeftButton()){return ;} ;if(element[OxO71a6[154]]){element[OxO71a6[118]]=OxO71a6[155];return ;} ;if(element[OxO71a6[142]]){element[OxO71a6[118]]=OxO71a6[143];} else {if(element[OxO71a6[156]]){element[OxO71a6[118]]=OxO71a6[157];} else {element[OxO71a6[118]]=OxO71a6[120];} ;} ;} ;var CuteEditorGlobalFunctions=[CuteEditor_GetEditor,CuteEditor_ButtonOver,CuteEditor_ButtonOut,CuteEditor_ButtonDown,CuteEditor_ButtonUp,CuteEditor_ColorPicker_ButtonOver,CuteEditor_ColorPicker_ButtonOut,CuteEditor_ColorPicker_ButtonDown,CuteEditor_ButtonCommandOver,CuteEditor_ButtonCommandOut,CuteEditor_ButtonCommandDown,CuteEditor_ButtonCommandUp,CuteEditor_DropDownCommand,CuteEditor_ExpandTreeDropDownItem,CuteEditor_CollapseTreeDropDownItem,CuteEditor_OnInitialized,CuteEditor_OnCommand,CuteEditor_OnChange,CuteEditor_AddVerbMenuItems,CuteEditor_AddTagMenuItems,CuteEditor_AddMainMenuItems,CuteEditor_AddDropMenuItems,CuteEditor_FilterCode,CuteEditor_FilterHTML];function SetupCuteEditorGlobalFunctions(){for(var i=0;i<CuteEditorGlobalFunctions[OxO71a6[18]];i++){var Ox18f=CuteEditorGlobalFunctions[i];var name=Ox18f+OxO71a6[17];name=name.substr(8,name.indexOf(OxO71a6[159])-8).replace(/\s/g,OxO71a6[17]);if(!window[name]){window[name]=Ox18f;} ;} ;} ;SetupCuteEditorGlobalFunctions();var __danainfo=null;var danaurl=window[OxO71a6[161]][OxO71a6[160]];var danapos=danaurl.indexOf(OxO71a6[162]);if(danapos!=-1){var pluspos1=danaurl.indexOf(OxO71a6[163],danapos+10);var pluspos2=danaurl.indexOf(OxO71a6[164],danapos+10);if(pluspos1!=-1&&pluspos1<pluspos2){pluspos2=pluspos1;} ;__danainfo=danaurl.substring(danapos,pluspos2)+OxO71a6[164];} ;function CuteEditor_GetScriptProperty(name){var Ox142=this[OxO71a6[165]][name];if(Ox142&&__danainfo){if(name==OxO71a6[96]){return Ox142+__danainfo;} ;var Ox381=this[OxO71a6[165]][OxO71a6[96]];if(Ox142.substr(0,Ox381.length)==Ox381){return Ox381+__danainfo+Ox142.substring(Ox381.length);} ;} ;return Ox142;} ;function CuteEditor_SetScriptProperty(name,Ox142){if(Ox142==null){this[OxO71a6[165]][name]=null;} else {this[OxO71a6[165]][name]=String(Ox142);} ;} ;function CuteEditorInitialize(Oxa52,Oxa53){var editor=Window_GetElement(window,Oxa52,true);editor[OxO71a6[165]]=Oxa53;editor[OxO71a6[166]]=CuteEditor_GetScriptProperty;var Ox76f=Window_GetElement(window,editor.GetScriptProperty(OxO71a6[134]),true);var editwin=Frame_GetContentWindow(Ox76f);var editdoc=editwin[OxO71a6[11]];var Oxa54=false;var Oxa55;var Oxa56=false;var Oxa57=editor.GetScriptProperty(OxO71a6[96])+OxO71a6[167]+editor.GetScriptProperty(OxO71a6[168]);function Oxa58(){if( typeof (window[OxO71a6[169]])==OxO71a6[170]){return ;} ;LoadXMLAsync(OxO71a6[171],Oxa57+OxO71a6[172]+ new Date().getTime(),Oxa59);} ;function Oxa59(Ox28f){var Ox883= new Date().getTime();if(Ox28f[OxO71a6[173]]!=200){} else {Ox883=Ox28f[OxO71a6[174]];} ;LoadXMLAsync(OxO71a6[175],Oxa57+OxO71a6[176]+Ox883,Oxa5a);} ;function Oxa5a(Ox28f){if(Ox28f[OxO71a6[173]]!=200){alert(OxO71a6[177]);return ;} ;CuteEditorInstallScriptCode(Ox28f.responseText,OxO71a6[169]);if(Oxa54){Oxa5b();} ;} ;function Oxa5b(){if(Oxa56){return ;} ;Oxa56=true;Ox76f[OxO71a6[46]][OxO71a6[45]]=OxO71a6[178];if(Browser_IsOpera()){editdoc[OxO71a6[180]][OxO71a6[179]]=true;} else {if(Browser_IsGecko()){editdoc[OxO71a6[180]][OxO71a6[48]]=OxO71a6[181];} ;editdoc[OxO71a6[182]]=OxO71a6[60];} ;window.CuteEditorImplementation(editor);try{editor[OxO71a6[46]][OxO71a6[183]]=OxO71a6[17];} catch(x){} ;try{editdoc[OxO71a6[180]][OxO71a6[46]][OxO71a6[183]]=OxO71a6[17];} catch(x){} ;var Oxa5c=editor.GetScriptProperty(OxO71a6[184]);if(Oxa5c){editor.Eval(Oxa5c);} ;} ;function Oxa5d(){if(!Element_Contains(window[OxO71a6[11]].body,editor)){return ;} ;try{Ox76f=Window_GetElement(window,editor.GetScriptProperty(OxO71a6[134]),true);editwin=Frame_GetContentWindow(Ox76f);editdoc=editwin[OxO71a6[11]];var y=editdoc[OxO71a6[180]];} catch(x){setTimeout(Oxa5d,100);return ;} ;if(!editdoc[OxO71a6[180]]){setTimeout(Oxa5d,100);return ;} ;if(!Oxa54){Oxa54=true;setTimeout(Oxa5d,50);return ;} ;if( typeof (window[OxO71a6[169]])==OxO71a6[170]){Oxa5b();} else {} ;} ;CuteEditor_BasicInitialize(editor);Oxa58();Oxa5d();} ;function CuteEditorInstallScriptCode(Ox9b6,Ox9b7){eval(Ox9b6);window[Ox9b7]=eval(Ox9b7);} ;window[OxO71a6[185]]=CuteEditorInitialize;