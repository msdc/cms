var OxO7801=["ua","userAgent","isOpera","opera","isSafari","safari","isGecko","gecko","isWinIE","msie","compatMode","document","CSS1Compat","undefined","Microsoft.XMLHTTP","readyState","onreadystatechange","","length","all","childNodes","nodeType","\x0D\x0A","caller","onchange","oninitialized","command","commandui","commandvalue","returnValue","oncommand","string","_fireEventFunction","event","parentNode","_IsCuteEditor","True","value","arguments","target","nodeName","SELECT","OPTION","readOnly","_IsRichDropDown","null","selectedIndex","TR","cells","display","style","nextSibling","innerHTML","\x3Cimg src=\x22","/Load.ashx?type=image\x26file=t-minus.gif\x22\x3E","onclick","CuteEditor_CollapseTreeDropDownItem(this,\x22","\x22)","none","/Load.ashx?type=image\x26file=t-plus.gif\x22\x3E","CuteEditor_ExpandTreeDropDownItem(this,\x22","contains","UNSELECTABLE","on","tabIndex","-1","//TODO: event not found? throw error ?","contentWindow","contentDocument","parentWindow","id","frames","frameElement","//TODO:frame contentWindow not found?","preventDefault","parent","top","opener","head","script","language","javascript","type","text/javascript","src","srcElement","//TODO: srcElement not found? throw error ?","fromElement","relatedTarget","toElement","keyCode","clientX","clientY","offsetX","offsetY","button","ctrlKey","altKey","shiftKey","cancelBubble","stopPropagation","CuteEditor_GetEditor(this).ExecImageCommand(this.getAttribute(\x27Command\x27),this.getAttribute(\x27CommandUI\x27),this.getAttribute(\x27CommandArgument\x27),this)","CuteEditor_GetEditor(this).PostBack(this.getAttribute(\x27Command\x27))","this.onmouseout();CuteEditor_GetEditor(this).DropMenu(this.getAttribute(\x27Group\x27),this)","ResourceDir","Theme","/Load.ashx?type=theme\x26theme=","\x26file=all.png","/Images/blank2020.gif","IMG","alt","title","Command","Group","ThemeIndex","width","20px","height","backgroundImage","url(",")","backgroundPosition","0 -","px","onload","className","separator","CuteEditorButton","onmouseover","CuteEditor_ButtonCommandOver(this)","onmouseout","CuteEditor_ButtonCommandOut(this)","onmousedown","CuteEditor_ButtonCommandDown(this)","onmouseup","CuteEditor_ButtonCommandUp(this)","oncontextmenu","ondragstart","PostBack","ondblclick","_ToolBarID","_CodeViewToolBarID","_FrameID"," CuteEditorFrame"," CuteEditorToolbar","cursor","no-drop","ActiveTab","Edit","Code","View","buttonInitialized","isover","CuteEditorButtonOver","CuteEditorButtonDown","CuteEditorDown","border","solid 1px #0A246A","backgroundColor","#b6bdd2","padding","1px","solid 1px #f5f5f4","inset 1px","IsCommandDisabled","CuteEditorButtonDisabled","IsCommandActive","CuteEditorButtonActive","cmd_fromfullpage","(","href","location",",DanaInfo=",",","+","scriptProperties","initfuncbecalled","GetScriptProperty","/Load.ashx?type=scripts\x26file=Gecko_Implementation\x26culture=","Culture","CuteEditorImplementation","function","POST","\x26getModified=1\x26_temp=","status","responseText","GET","\x26modified=","body","block","contentEditable","InitializeCode","inittime","CuteEditorInitialize"];var _Browser_TypeInfo=null;function Browser__InitType(){if(_Browser_TypeInfo!=null){return ;} ;var Ox4={};Ox4[OxO7801[0]]=navigator[OxO7801[1]].toLowerCase();Ox4[OxO7801[2]]=(Ox4[OxO7801[0]].indexOf(OxO7801[3])>-1);Ox4[OxO7801[4]]=(Ox4[OxO7801[0]].indexOf(OxO7801[5])>-1);Ox4[OxO7801[6]]=(!Ox4[OxO7801[2]]&&Ox4[OxO7801[0]].indexOf(OxO7801[7])>-1);Ox4[OxO7801[8]]=(!Ox4[OxO7801[2]]&&Ox4[OxO7801[0]].indexOf(OxO7801[9])>-1);_Browser_TypeInfo=Ox4;} ;Browser__InitType();function Browser_IsWinIE(){return _Browser_TypeInfo[OxO7801[8]];} ;function Browser_IsGecko(){return _Browser_TypeInfo[OxO7801[6]];} ;function Browser_IsOpera(){return _Browser_TypeInfo[OxO7801[2]];} ;function Browser_IsSafari(){return _Browser_TypeInfo[OxO7801[4]];} ;function Browser_UseIESelection(){return _Browser_TypeInfo[OxO7801[8]];} ;function Browser_IsCSS1Compat(){return window[OxO7801[11]][OxO7801[10]]==OxO7801[12];} ;function CreateXMLHttpRequest(){try{if( typeof (XMLHttpRequest)!=OxO7801[13]){return  new XMLHttpRequest();} ;if( typeof (ActiveXObject)!=OxO7801[13]){return  new ActiveXObject(OxO7801[14]);} ;} catch(x){return null;} ;} ;function LoadXMLAsync(Oxa37,Ox287,Ox234,Oxa38){var Oxe7=CreateXMLHttpRequest();function Oxa39(){if(Oxe7[OxO7801[15]]!=4){return ;} ;Oxe7[OxO7801[16]]= new Function();var Ox28f=Oxe7;Oxe7=null;if(Ox234){Ox234(Ox28f);} ;} ;Oxe7[OxO7801[16]]=Oxa39;Oxe7.open(Oxa37,Ox287,true);Oxe7.send(Oxa38||OxO7801[17]);} ;function Element_GetAllElements(p){var arr=[];if(Browser_IsWinIE()){for(var i=0;i<p[OxO7801[19]][OxO7801[18]];i++){arr.push(p[OxO7801[19]].item(i));} ;return arr;} ;Ox241(p);function Ox241(Ox29){var Ox217=Ox29[OxO7801[20]];var Ox11=Ox217[OxO7801[18]];for(var i=0;i<Ox11;i++){var Ox27=Ox217.item(i);if(Ox27[OxO7801[21]]!=1){continue ;} ;arr.push(Ox27);Ox241(Ox27);} ;} ;return arr;} ;var __ISDEBUG=false;function Debug_Todo(msg){if(!__ISDEBUG){return ;} ;throw ( new Error(msg+OxO7801[22]+Debug_Todo[OxO7801[23]]));} ;function Window_GetElement(Ox1a8,Ox9a,Ox23f){var Ox29=Ox1a8[OxO7801[11]].getElementById(Ox9a);if(Ox29){return Ox29;} ;var Ox31=Ox1a8[OxO7801[11]].getElementsByName(Ox9a);if(Ox31[OxO7801[18]]>0){return Ox31.item(0);} ;return null;} ;function CuteEditor_AddMainMenuItems(Ox667){} ;function CuteEditor_AddDropMenuItems(Ox667,Ox66e){} ;function CuteEditor_AddTagMenuItems(Ox667,Ox670){} ;function CuteEditor_AddVerbMenuItems(Ox667,Ox670){} ;function CuteEditor_OnInitialized(editor){} ;function CuteEditor_OnCommand(editor,Ox4d,Ox4e,Ox4f){} ;function CuteEditor_OnChange(editor){} ;function CuteEditor_FilterCode(editor,Ox26a){return Ox26a;} ;function CuteEditor_FilterHTML(editor,Ox282){return Ox282;} ;function CuteEditor_FireChange(editor){window.CuteEditor_OnChange(editor);CuteEditor_FireEvent(editor,OxO7801[24],null);} ;function CuteEditor_FireInitialized(editor){window.CuteEditor_OnInitialized(editor);CuteEditor_FireEvent(editor,OxO7801[25],null);} ;function CuteEditor_FireCommand(editor,Ox4d,Ox4e,Ox4f){var Ox13e=window.CuteEditor_OnCommand(editor,Ox4d,Ox4e,Ox4f);if(Ox13e==true){return true;} ;var Ox679={};Ox679[OxO7801[26]]=Ox4d;Ox679[OxO7801[27]]=Ox4e;Ox679[OxO7801[28]]=Ox4f;Ox679[OxO7801[29]]=true;CuteEditor_FireEvent(editor,OxO7801[30],Ox679);if(Ox679[OxO7801[29]]==false){return true;} ;} ;function CuteEditor_FireEvent(editor,Ox67b,Ox67c){if(Ox67c==null){Ox67c={};} ;var Ox67d=editor.getAttribute(Ox67b);if(Ox67d){if( typeof (Ox67d)==OxO7801[31]){editor[OxO7801[32]]= new Function(OxO7801[33],Ox67d);} else {editor[OxO7801[32]]=Ox67d;} ;editor._fireEventFunction(Ox67c);} ;} ;function CuteEditor_GetEditor(element){for(var Ox43=element;Ox43!=null;Ox43=Ox43[OxO7801[34]]){if(Ox43.getAttribute(OxO7801[35])==OxO7801[36]){return Ox43;} ;} ;return null;} ;function CuteEditor_DropDownCommand(element,Oxa3b){var Ox142=element[OxO7801[37]];if(CuteEditor_DropDownCommand[OxO7801[23]]){var Ox43=CuteEditor_DropDownCommand[OxO7801[23]][OxO7801[38]][0];if(Ox43&&Ox43[OxO7801[39]]){if(Ox43[OxO7801[39]][OxO7801[40]]==OxO7801[41]){return ;} ;if(Ox43[OxO7801[39]][OxO7801[40]]==OxO7801[42]){Ox142=Ox43[OxO7801[39]][OxO7801[37]];} ;} ;} ;var editor=CuteEditor_GetEditor(element);if(editor[OxO7801[43]]){return ;} ;if(element.getAttribute(OxO7801[44])==OxO7801[36]){var Ox142=element.GetValue();if(Ox142==OxO7801[45]){Ox142=OxO7801[17];} ;var Ox201=element.GetText();if(Ox201==OxO7801[45]){Ox201=OxO7801[17];} ;element.SetSelectedIndex(0);editor.ExecCommand(Oxa3b,false,Ox142,Ox201);} else {if(Ox142){if(Ox142==OxO7801[45]){Ox142=OxO7801[17];} ;element[OxO7801[46]]=0;editor.ExecCommand(Oxa3b,false,Ox142,Ox201);} else {element[OxO7801[46]]=0;} ;} ;editor.FocusDocument();} ;function CuteEditor_ExpandTreeDropDownItem(src,Ox73d){var Oxba=null;while(src!=null){if(src[OxO7801[40]]==OxO7801[47]){Oxba=src;break ;} ;src=src[OxO7801[34]];} ;var Ox1e4=Oxba[OxO7801[48]].item(0);Oxba[OxO7801[51]][OxO7801[50]][OxO7801[49]]=OxO7801[17];Ox1e4[OxO7801[52]]=OxO7801[53]+Ox73d+OxO7801[54];Oxba[OxO7801[55]]= new Function(OxO7801[56]+Ox73d+OxO7801[57]);} ;function CuteEditor_CollapseTreeDropDownItem(src,Ox73d){var Oxba=null;while(src!=null){if(src[OxO7801[40]]==OxO7801[47]){Oxba=src;break ;} ;src=src[OxO7801[34]];} ;var Ox1e4=Oxba[OxO7801[48]].item(0);Oxba[OxO7801[51]][OxO7801[50]][OxO7801[49]]=OxO7801[58];Ox1e4[OxO7801[52]]=OxO7801[53]+Ox73d+OxO7801[59];Oxba[OxO7801[55]]= new Function(OxO7801[60]+Ox73d+OxO7801[57]);} ;function Element_Contains(element,Ox183){if(!Browser_IsOpera()){if(element[OxO7801[61]]){return element.contains(Ox183);} ;} ;for(;Ox183!=null;Ox183=Ox183[OxO7801[34]]){if(element==Ox183){return true;} ;} ;return false;} ;function Element_SetUnselectable(element){element.setAttribute(OxO7801[62],OxO7801[63]);element.setAttribute(OxO7801[64],OxO7801[65]);var arr=Element_GetAllElements(element);var len=arr[OxO7801[18]];if(!len){return ;} ;for(var i=0;i<len;i++){arr[i].setAttribute(OxO7801[62],OxO7801[63]);arr[i].setAttribute(OxO7801[64],OxO7801[65]);} ;} ;function Event_GetEvent(Ox244){Ox244=Event_FindEvent(Ox244);if(Ox244==null){Debug_Todo(OxO7801[66]);} ;return Ox244;} ;function Frame_GetContentWindow(Ox348){if(Ox348[OxO7801[67]]){return Ox348[OxO7801[67]];} ;if(Ox348[OxO7801[68]]){if(Ox348[OxO7801[68]][OxO7801[69]]){return Ox348[OxO7801[68]][OxO7801[69]];} ;} ;var Ox1a8;if(Ox348[OxO7801[70]]){Ox1a8=window[OxO7801[71]][Ox348[OxO7801[70]]];if(Ox1a8){return Ox1a8;} ;} ;var len=window[OxO7801[71]][OxO7801[18]];for(var i=0;i<len;i++){Ox1a8=window[OxO7801[71]][i];if(Ox1a8[OxO7801[72]]==Ox348){return Ox1a8;} ;if(Ox1a8[OxO7801[11]]==Ox348[OxO7801[68]]){return Ox1a8;} ;} ;Debug_Todo(OxO7801[73]);} ;function Array_IndexOf(arr,Ox246){for(var i=0;i<arr[OxO7801[18]];i++){if(arr[i]==Ox246){return i;} ;} ;return -1;} ;function Array_Contains(arr,Ox246){return Array_IndexOf(arr,Ox246)!=-1;} ;function Event_FindEvent(Ox244){if(Ox244&&Ox244[OxO7801[74]]){return Ox244;} ;if(Browser_IsGecko()){return Event_FindEvent_FindEventFromCallers();} else {if(window[OxO7801[33]]){return window[OxO7801[33]];} ;return Event_FindEvent_FindEventFromWindows();} ;return null;} ;function Event_FindEvent_FindEventFromCallers(){var Ox18f=Event_GetEvent[OxO7801[23]];for(var i=0;i<100;i++){if(!Ox18f){break ;} ;var Ox244=Ox18f[OxO7801[38]][0];if(Ox244&&Ox244[OxO7801[74]]){return Ox244;} ;Ox18f=Ox18f[OxO7801[23]];} ;} ;function Event_FindEvent_FindEventFromWindows(){var arr=[];return Ox24d(window);function Ox24d(Ox1a8){if(Ox1a8==null){return null;} ;if(Ox1a8[OxO7801[33]]){return Ox1a8[OxO7801[33]];} ;if(Array_Contains(arr,Ox1a8)){return null;} ;arr.push(Ox1a8);var Ox24e=[];if(Ox1a8[OxO7801[75]]!=Ox1a8){Ox24e.push(Ox1a8.parent);} ;if(Ox1a8[OxO7801[76]]!=Ox1a8[OxO7801[75]]){Ox24e.push(Ox1a8.top);} ;if(Ox1a8[OxO7801[77]]){Ox24e.push(Ox1a8.opener);} ;for(var i=0;i<Ox1a8[OxO7801[71]][OxO7801[18]];i++){Ox24e.push(Ox1a8[OxO7801[71]][i]);} ;for(var i=0;i<Ox24e[OxO7801[18]];i++){try{var Ox244=Ox24d(Ox24e[i]);if(Ox244){return Ox244;} ;} catch(x){} ;} ;return null;} ;} ;function include(Oxc9,Ox287){var Ox288=document.getElementsByTagName(OxO7801[78]).item(0);var Ox289=document.getElementById(Oxc9);if(Ox289){Ox288.removeChild(Ox289);} ;var Ox28a=document.createElement(OxO7801[79]);Ox28a.setAttribute(OxO7801[80],OxO7801[81]);Ox28a.setAttribute(OxO7801[82],OxO7801[83]);Ox28a.setAttribute(OxO7801[84],Ox287);Ox28a.setAttribute(OxO7801[70],Oxc9);Ox288.appendChild(Ox28a);} ;function Event_GetSrcElement(Ox244){Ox244=Event_GetEvent(Ox244);if(Ox244[OxO7801[85]]){return Ox244[OxO7801[85]];} ;if(Ox244[OxO7801[39]]){return Ox244[OxO7801[39]];} ;Debug_Todo(OxO7801[86]);return null;} ;function Event_GetFromElement(Ox244){Ox244=Event_GetEvent(Ox244);if(Ox244[OxO7801[87]]){return Ox244[OxO7801[87]];} ;if(Ox244[OxO7801[88]]){return Ox244[OxO7801[88]];} ;return null;} ;function Event_GetToElement(Ox244){Ox244=Event_GetEvent(Ox244);if(Ox244[OxO7801[89]]){return Ox244[OxO7801[89]];} ;if(Ox244[OxO7801[88]]){return Ox244[OxO7801[88]];} ;return null;} ;function Event_GetKeyCode(Ox244){Ox244=Event_GetEvent(Ox244);return Ox244[OxO7801[90]];} ;function Event_GetClientX(Ox244){Ox244=Event_GetEvent(Ox244);return Ox244[OxO7801[91]];} ;function Event_GetClientY(Ox244){Ox244=Event_GetEvent(Ox244);return Ox244[OxO7801[92]];} ;function Event_GetOffsetX(Ox244){Ox244=Event_GetEvent(Ox244);return Ox244[OxO7801[93]];} ;function Event_GetOffsetY(Ox244){Ox244=Event_GetEvent(Ox244);return Ox244[OxO7801[94]];} ;function Event_IsLeftButton(Ox244){Ox244=Event_GetEvent(Ox244);if(Browser_IsWinIE()){return Ox244[OxO7801[95]]==1;} ;if(Browser_IsGecko()){return Ox244[OxO7801[95]]==0;} ;return Ox244[OxO7801[95]]==0;} ;function Event_IsCtrlKey(Ox244){Ox244=Event_GetEvent(Ox244);return Ox244[OxO7801[96]];} ;function Event_IsAltKey(Ox244){Ox244=Event_GetEvent(Ox244);return Ox244[OxO7801[97]];} ;function Event_IsShiftKey(Ox244){Ox244=Event_GetEvent(Ox244);return Ox244[OxO7801[98]];} ;function Event_PreventDefault(Ox244){Ox244=Event_GetEvent(Ox244);Ox244[OxO7801[29]]=false;if(Ox244[OxO7801[74]]){Ox244.preventDefault();} ;} ;function Event_CancelBubble(Ox244){Ox244=Event_GetEvent(Ox244);Ox244[OxO7801[99]]=true;if(Ox244[OxO7801[100]]){Ox244.stopPropagation();} ;return false;} ;function Event_CancelEvent(Ox244){Ox244=Event_GetEvent(Ox244);Event_PreventDefault(Ox244);return Event_CancelBubble(Ox244);} ;function CuteEditor_BasicInitialize(editor){var Ox158=Browser_IsOpera();var Ox706= new Function(OxO7801[101]);var Oxa3f= new Function(OxO7801[102]);var Oxa40= new Function(OxO7801[103]);var Oxa41=editor.GetScriptProperty(OxO7801[104]);var Oxa42=editor.GetScriptProperty(OxO7801[105]);var Oxa43=Oxa41+OxO7801[106]+Oxa42+OxO7801[107];var Oxa44=Oxa41+OxO7801[108];var images=editor.getElementsByTagName(OxO7801[109]);var len=images[OxO7801[18]];for(var i=0;i<len;i++){var img=images[i];if(img.getAttribute(OxO7801[110])&&!img.getAttribute(OxO7801[111])){img.setAttribute(OxO7801[111],img.getAttribute(OxO7801[110]));} ;var Ox135=img.getAttribute(OxO7801[112]);var Ox66e=img.getAttribute(OxO7801[113]);if(!(Ox135||Ox66e)){continue ;} ;var Oxa45=img.getAttribute(OxO7801[114]);if(parseInt(Oxa45)>=0){img[OxO7801[50]][OxO7801[115]]=OxO7801[116];img[OxO7801[50]][OxO7801[117]]=OxO7801[116];img[OxO7801[84]]=Oxa44;img[OxO7801[50]][OxO7801[118]]=OxO7801[119]+Oxa43+OxO7801[120];img[OxO7801[50]][OxO7801[121]]=OxO7801[122]+(Oxa45*20)+OxO7801[123];img[OxO7801[50]][OxO7801[49]]=OxO7801[17];} ;if(!Ox135&&!Ox66e){if(Ox158){img[OxO7801[124]]=CuteEditor_OperaHandleImageLoaded;} ;continue ;} ;if(img[OxO7801[125]]!=OxO7801[126]){img[OxO7801[125]]=OxO7801[127];img[OxO7801[128]]= new Function(OxO7801[129]);img[OxO7801[130]]= new Function(OxO7801[131]);img[OxO7801[132]]= new Function(OxO7801[133]);img[OxO7801[134]]= new Function(OxO7801[135]);} ;if(!img[OxO7801[136]]){img[OxO7801[136]]=Event_CancelEvent;} ;if(!img[OxO7801[137]]){img[OxO7801[137]]=Event_CancelEvent;} ;if(Ox135){var Ox18f=img.getAttribute(OxO7801[138])==OxO7801[36]?Oxa3f:Ox706;if(img[OxO7801[55]]==null){img[OxO7801[55]]=Ox18f;} ;if(img[OxO7801[139]]==null){img[OxO7801[139]]=Ox18f;} ;} else {if(Ox66e){if(img[OxO7801[55]]==null){img[OxO7801[55]]=Oxa40;} ;} ;} ;} ;var Ox773=Window_GetElement(window,editor.GetScriptProperty(OxO7801[140]),true);var Ox774=Window_GetElement(window,editor.GetScriptProperty(OxO7801[141]),true);var Ox76f=Window_GetElement(window,editor.GetScriptProperty(OxO7801[142]),true);Ox76f[OxO7801[125]]+=OxO7801[143];Ox773[OxO7801[125]]+=OxO7801[144];Ox774[OxO7801[125]]+=OxO7801[144];Element_SetUnselectable(Ox773);Element_SetUnselectable(Ox774);try{editor[OxO7801[50]][OxO7801[145]]=OxO7801[146];} catch(x){} ;var Ox7f9=editor.GetScriptProperty(OxO7801[147]);switch(Ox7f9){case OxO7801[148]:Ox773[OxO7801[50]][OxO7801[49]]=OxO7801[17];break ;;case OxO7801[149]:Ox774[OxO7801[50]][OxO7801[49]]=OxO7801[17];break ;;case OxO7801[150]:break ;;} ;} ;function CuteEditor_OperaHandleImageLoaded(){var img=this;if(img[OxO7801[50]][OxO7801[49]]){img[OxO7801[50]][OxO7801[49]]=OxO7801[58];setTimeout(function Oxa47(){img[OxO7801[50]][OxO7801[49]]=OxO7801[17];} ,1);} ;} ;function CuteEditor_ButtonOver(element){if(!element[OxO7801[151]]){element[OxO7801[136]]=Event_CancelEvent;element[OxO7801[130]]=CuteEditor_ButtonOut;element[OxO7801[132]]=CuteEditor_ButtonDown;element[OxO7801[134]]=CuteEditor_ButtonUp;Element_SetUnselectable(element);element[OxO7801[151]]=true;} ;element[OxO7801[152]]=true;element[OxO7801[125]]=OxO7801[153];} ;function CuteEditor_ButtonOut(){var element=this;element[OxO7801[125]]=OxO7801[127];element[OxO7801[152]]=false;} ;function CuteEditor_ButtonDown(){if(!Event_IsLeftButton()){return ;} ;var element=this;element[OxO7801[125]]=OxO7801[154];} ;function CuteEditor_ButtonUp(){if(!Event_IsLeftButton()){return ;} ;var element=this;if(element[OxO7801[152]]){element[OxO7801[125]]=OxO7801[153];} else {element[OxO7801[125]]=OxO7801[155];} ;} ;function CuteEditor_ColorPicker_ButtonOver(element){if(!element[OxO7801[151]]){element[OxO7801[136]]=Event_CancelEvent;element[OxO7801[130]]=CuteEditor_ColorPicker_ButtonOut;element[OxO7801[132]]=CuteEditor_ColorPicker_ButtonDown;Element_SetUnselectable(element);element[OxO7801[151]]=true;} ;element[OxO7801[152]]=true;element[OxO7801[50]][OxO7801[156]]=OxO7801[157];element[OxO7801[50]][OxO7801[158]]=OxO7801[159];element[OxO7801[50]][OxO7801[160]]=OxO7801[161];} ;function CuteEditor_ColorPicker_ButtonOut(){var element=this;element[OxO7801[152]]=false;element[OxO7801[50]][OxO7801[156]]=OxO7801[162];element[OxO7801[50]][OxO7801[158]]=OxO7801[17];element[OxO7801[50]][OxO7801[160]]=OxO7801[161];} ;function CuteEditor_ColorPicker_ButtonDown(){var element=this;element[OxO7801[50]][OxO7801[156]]=OxO7801[163];element[OxO7801[50]][OxO7801[158]]=OxO7801[17];element[OxO7801[50]][OxO7801[160]]=OxO7801[161];} ;function CuteEditor_ButtonCommandOver(element){element[OxO7801[152]]=true;if(element[OxO7801[164]]){element[OxO7801[125]]=OxO7801[165];} else {element[OxO7801[125]]=OxO7801[153];} ;} ;function CuteEditor_ButtonCommandOut(element){element[OxO7801[152]]=false;if(element[OxO7801[166]]){element[OxO7801[125]]=OxO7801[167];} else {if(element[OxO7801[164]]){element[OxO7801[125]]=OxO7801[165];} else {if(element[OxO7801[70]]!=OxO7801[168]){element[OxO7801[125]]=OxO7801[127];} ;} ;} ;} ;function CuteEditor_ButtonCommandDown(element){if(!Event_IsLeftButton()){return ;} ;element[OxO7801[125]]=OxO7801[154];} ;function CuteEditor_ButtonCommandUp(element){if(!Event_IsLeftButton()){return ;} ;if(element[OxO7801[164]]){element[OxO7801[125]]=OxO7801[165];return ;} ;if(element[OxO7801[152]]){element[OxO7801[125]]=OxO7801[153];} else {if(element[OxO7801[166]]){element[OxO7801[125]]=OxO7801[167];} else {element[OxO7801[125]]=OxO7801[127];} ;} ;} ;var CuteEditorGlobalFunctions=[CuteEditor_GetEditor,CuteEditor_ButtonOver,CuteEditor_ButtonOut,CuteEditor_ButtonDown,CuteEditor_ButtonUp,CuteEditor_ColorPicker_ButtonOver,CuteEditor_ColorPicker_ButtonOut,CuteEditor_ColorPicker_ButtonDown,CuteEditor_ButtonCommandOver,CuteEditor_ButtonCommandOut,CuteEditor_ButtonCommandDown,CuteEditor_ButtonCommandUp,CuteEditor_DropDownCommand,CuteEditor_ExpandTreeDropDownItem,CuteEditor_CollapseTreeDropDownItem,CuteEditor_OnInitialized,CuteEditor_OnCommand,CuteEditor_OnChange,CuteEditor_AddVerbMenuItems,CuteEditor_AddTagMenuItems,CuteEditor_AddMainMenuItems,CuteEditor_AddDropMenuItems,CuteEditor_FilterCode,CuteEditor_FilterHTML];function SetupCuteEditorGlobalFunctions(){for(var i=0;i<CuteEditorGlobalFunctions[OxO7801[18]];i++){var Ox18f=CuteEditorGlobalFunctions[i];var name=Ox18f+OxO7801[17];name=name.substr(8,name.indexOf(OxO7801[169])-8).replace(/\s/g,OxO7801[17]);if(!window[name]){window[name]=Ox18f;} ;} ;} ;SetupCuteEditorGlobalFunctions();var __danainfo=null;var danaurl=window[OxO7801[171]][OxO7801[170]];var danapos=danaurl.indexOf(OxO7801[172]);if(danapos!=-1){var pluspos1=danaurl.indexOf(OxO7801[173],danapos+10);var pluspos2=danaurl.indexOf(OxO7801[174],danapos+10);if(pluspos1!=-1&&pluspos1<pluspos2){pluspos2=pluspos1;} ;__danainfo=danaurl.substring(danapos,pluspos2)+OxO7801[174];} ;function CuteEditor_GetScriptProperty(name){var Ox142=this[OxO7801[175]][name];if(Ox142&&__danainfo){if(name==OxO7801[104]){return Ox142+__danainfo;} ;var Ox381=this[OxO7801[175]][OxO7801[104]];if(Ox142.substr(0,Ox381.length)==Ox381){return Ox381+__danainfo+Ox142.substring(Ox381.length);} ;} ;return Ox142;} ;function CuteEditor_SetScriptProperty(name,Ox142){if(Ox142==null){this[OxO7801[175]][name]=null;} else {this[OxO7801[175]][name]=String(Ox142);} ;} ;function CuteEditorInitialize(Oxa52,Oxa53){var editor=Window_GetElement(window,Oxa52,true);if(editor[OxO7801[176]]){return ;} ;editor[OxO7801[176]]=1;editor[OxO7801[175]]=Oxa53;editor[OxO7801[177]]=CuteEditor_GetScriptProperty;var Ox76f=Window_GetElement(window,editor.GetScriptProperty(OxO7801[142]),true);var editwin,editdoc;try{editwin=Frame_GetContentWindow(Ox76f);editdoc=editwin[OxO7801[11]];} catch(x){} ;var Oxa54=false;var Oxa55;var Oxa56=false;var Oxa57=editor.GetScriptProperty(OxO7801[104])+OxO7801[178]+editor.GetScriptProperty(OxO7801[179]);function Oxa58(){if( typeof (window[OxO7801[180]])==OxO7801[181]){return ;} ;LoadXMLAsync(OxO7801[182],Oxa57+OxO7801[183]+ new Date().getTime(),Oxa59);} ;function Oxa59(Ox28f){var Ox883= new Date().getTime();if(Ox28f[OxO7801[184]]!=200){} else {Ox883=Ox28f[OxO7801[185]];} ;LoadXMLAsync(OxO7801[186],Oxa57+OxO7801[187]+Ox883,Oxa5a);} ;function Oxa5a(Ox28f){if(Ox28f[OxO7801[184]]!=200){return ;} ;CuteEditorInstallScriptCode(Ox28f.responseText,OxO7801[180]);if(Oxa54){Oxa5b();} ;} ;function Oxa5b(){if(Oxa56){return ;} ;Oxa56=true;try{editor[OxO7801[50]][OxO7801[145]]=OxO7801[17];} catch(x){} ;try{editdoc[OxO7801[188]][OxO7801[50]][OxO7801[145]]=OxO7801[17];} catch(x){} ;Ox76f[OxO7801[50]][OxO7801[49]]=OxO7801[189];if(Browser_IsOpera()){editdoc[OxO7801[188]][OxO7801[190]]=true;} else {} ;window.CuteEditorImplementation(editor);var Oxa5c=editor.GetScriptProperty(OxO7801[191]);if(Oxa5c){editor.Eval(Oxa5c);} ;} ;function Oxa5d(){if(!Element_Contains(window[OxO7801[11]].body,editor)){return ;} ;document[OxO7801[111]]=OxO7801[17];try{Ox76f=Window_GetElement(window,editor.GetScriptProperty(OxO7801[142]),true);if(!Ox76f.getAttribute(OxO7801[192])){Ox76f.setAttribute(OxO7801[192], new Date().getTime());} ;editwin=Frame_GetContentWindow(Ox76f);editdoc=editwin[OxO7801[11]];var y=editdoc[OxO7801[188]];} catch(x){if(Ox76f!=null){Ox76f.setAttribute(OxO7801[84],Ox76f.src);} ;setTimeout(Oxa5d,100);return ;} ;if(!editdoc[OxO7801[188]]){setTimeout(Oxa5d,100);return ;} ;if(!Oxa54){Oxa54=true;setTimeout(Oxa5d,50);return ;} ;if( typeof (window[OxO7801[180]])==OxO7801[181]){Oxa5b();} else {try{editdoc[OxO7801[188]][OxO7801[50]][OxO7801[145]]=OxO7801[146];} catch(x){} ;} ;} ;var Oxa5e=0;var Ox43=CuteEditor_Find_DisplayNone(editor);if(Ox43){function Oxa5f(){if(Ox43[OxO7801[50]][OxO7801[49]]!=OxO7801[58]){window.clearInterval(Oxa5e);Oxa5e=OxO7801[17];editor[OxO7801[176]]=false;CuteEditorInitialize(Oxa52,Oxa53);} ;} ;Oxa5e=setInterval(Oxa5f,1000);} else {CuteEditor_BasicInitialize(editor);Oxa58();Oxa5d();} ;function CuteEditor_Find_DisplayNone(element){var Oxa61;for(var Ox43=element;Ox43!=null;Ox43=Ox43[OxO7801[34]]){if(Ox43[OxO7801[50]]&&Ox43[OxO7801[50]][OxO7801[49]]==OxO7801[58]){Oxa61=Ox43;break ;} ;} ;return Oxa61;} ;} ;function CuteEditorInstallScriptCode(Ox9b6,Ox9b7){eval(Ox9b6);window[Ox9b7]=eval(Ox9b7);} ;window[OxO7801[193]]=CuteEditorInitialize;