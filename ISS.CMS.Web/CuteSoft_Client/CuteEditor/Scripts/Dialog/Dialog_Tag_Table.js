var OxO872e=["","removeNode","parentNode","firstChild","nodeName","TABLE","length","Can\x27t Get The Position ?","Map","RowCount","ColCount","rows","cells","Unknown Error , pos ",":"," already have cell","rowSpan","colSpan","Unknown Error , Unable to find bestpos","inp_cellspacing","inp_cellpadding","inp_id","inp_border","inp_bgcolor","inp_bordercolor","sel_rules","inp_collapse","inp_summary","btn_editcaption","btn_delcaption","btn_insthead","btn_instfoot","inp_class","inp_width","sel_width_unit","inp_height","sel_height_unit","sel_align","sel_textalign","sel_float","inp_tooltip","onclick","tHead","tFoot","caption","innerHTML","[[Caption]]","innerText","Unable to delete the caption. Please remove it in HTML source.","[[Delete]]","[[Insert]]","[[Edit]]","display","style","none","disabled","value","cellSpacing","cellPadding","id","border","borderColor","backgroundColor","bgColor","checked","borderCollapse","collapse","rules","summary","className","width","options","selectedIndex","height","align","styleFloat","cssFloat","textAlign","title","bordercolor","[[ValidID]]","0","%","class","CaptionTable"];function ParseFloatToString(Ox24){var Ox8=parseFloat(Ox24);if(isNaN(Ox8)){return OxO872e[0];} ;return Ox8+OxO872e[0];} ;function Element_RemoveNode(element,Ox511){if(element[OxO872e[1]]){element.removeNode(Ox511);return ;} ;var p=element[OxO872e[2]];if(!p){return ;} ;if(Ox511){p.removeChild(element);return ;} ;while(true){var Ox217=element[OxO872e[3]];if(!Ox217){break ;} ;p.insertBefore(Ox217,element);} ;p.removeChild(element);} ;function Table_GetTable(Ox43){for(;Ox43!=null;Ox43=Ox43[OxO872e[2]]){if(Ox43[OxO872e[4]]==OxO872e[5]){return Ox43;} ;} ;return null;} ;function Table_GetCellPositionFromMap(Ox50b,Ox396){for(var y=0;y<Ox50b[OxO872e[6]];y++){var Ox50e=Ox50b[y];for(var x=0;x<Ox50e[OxO872e[6]];x++){if(Ox50e[x]==Ox396){return {rowIndex:y,cellIndex:x};} ;} ;} ;throw ( new Error(-1,OxO872e[7]));} ;function Table_GetCellMap(Ox394){return Table_CalculateTableInfo(Ox394)[OxO872e[8]];} ;function Table_GetRowCount(Ox43){return Table_CalculateTableInfo(Ox43)[OxO872e[9]];} ;function Table_GetColCount(Ox43){return Table_CalculateTableInfo(Ox43)[OxO872e[10]];} ;function Table_CalculateTableInfo(Ox43){var Ox394=Table_GetTable(Ox43);var Ox51e=Ox394[OxO872e[11]];for(var Oxa=Ox51e[OxO872e[6]]-1;Oxa>=0;Oxa--){var Ox386=Ox51e.item(Oxa);if(Ox386[OxO872e[12]][OxO872e[6]]==0){Element_RemoveNode(Ox386,true);continue ;} ;} ;var Ox51f=Ox51e[OxO872e[6]];var Ox520=0;var Ox521= new Array(Ox51e.length);for(var Ox522=0;Ox522<Ox51f;Ox522++){Ox521[Ox522]=[];} ;function Ox523(Oxa,Ox217,Ox396){while(Oxa>=Ox51f){Ox521[Ox51f]=[];Ox51f++;} ;var Ox524=Ox521[Oxa];if(Ox217>=Ox520){Ox520=Ox217+1;} ;if(Ox524[Ox217]!=null){throw ( new Error(-1,OxO872e[13]+Oxa+OxO872e[14]+Ox217+OxO872e[15]));} ;Ox524[Ox217]=Ox396;} ;function Ox525(Oxa,Ox217){var Ox524=Ox521[Oxa];if(Ox524){return Ox524[Ox217];} ;} ;for(var Ox522=0;Ox522<Ox51e[OxO872e[6]];Ox522++){var Ox386=Ox51e.item(Ox522);var Ox526=Ox386[OxO872e[12]];for(var Ox39a=0;Ox39a<Ox526[OxO872e[6]];Ox39a++){var Ox396=Ox526.item(Ox39a);var Ox527=Ox396[OxO872e[16]];var Ox528=Ox396[OxO872e[17]];var Ox524=Ox521[Ox522];var Ox529=-1;for(var Ox52a=0;Ox52a<Ox520+Ox528+1;Ox52a++){if(Ox527==1&&Ox528==1){if(Ox524[Ox52a]==null){Ox529=Ox52a;break ;} ;} else {var Ox52b=true;for(var Ox52c=0;Ox52c<Ox527;Ox52c++){for(var Ox52d=0;Ox52d<Ox528;Ox52d++){if(Ox525(Ox522+Ox52c,Ox52a+Ox52d)!=null){Ox52b=false;break ;} ;} ;} ;if(Ox52b){Ox529=Ox52a;break ;} ;} ;} ;if(Ox529==-1){throw ( new Error(-1,OxO872e[18]));} ;if(Ox527==1&&Ox528==1){Ox523(Ox522,Ox529,Ox396);} else {for(var Ox52c=0;Ox52c<Ox527;Ox52c++){for(var Ox52d=0;Ox52d<Ox528;Ox52d++){Ox523(Ox522+Ox52c,Ox529+Ox52d,Ox396);} ;} ;} ;} ;} ;var Ox13e={};Ox13e[OxO872e[9]]=Ox51f;Ox13e[OxO872e[10]]=Ox520;Ox13e[OxO872e[8]]=Ox521;for(var Oxa=0;Oxa<Ox51f;Oxa++){var Ox524=Ox521[Oxa];for(var Ox217=0;Ox217<Ox520;Ox217++){} ;} ;return Ox13e;} ;var inp_cellspacing=Window_GetElement(window,OxO872e[19],true);var inp_cellpadding=Window_GetElement(window,OxO872e[20],true);var inp_id=Window_GetElement(window,OxO872e[21],true);var inp_border=Window_GetElement(window,OxO872e[22],true);var inp_bgcolor=Window_GetElement(window,OxO872e[23],true);var inp_bordercolor=Window_GetElement(window,OxO872e[24],true);var sel_rules=Window_GetElement(window,OxO872e[25],true);var inp_collapse=Window_GetElement(window,OxO872e[26],true);var inp_summary=Window_GetElement(window,OxO872e[27],true);var btn_editcaption=Window_GetElement(window,OxO872e[28],true);var btn_delcaption=Window_GetElement(window,OxO872e[29],true);var btn_insthead=Window_GetElement(window,OxO872e[30],true);var btn_instfoot=Window_GetElement(window,OxO872e[31],true);var inp_class=Window_GetElement(window,OxO872e[32],true);var inp_width=Window_GetElement(window,OxO872e[33],true);var sel_width_unit=Window_GetElement(window,OxO872e[34],true);var inp_height=Window_GetElement(window,OxO872e[35],true);var sel_height_unit=Window_GetElement(window,OxO872e[36],true);var sel_align=Window_GetElement(window,OxO872e[37],true);var sel_textalign=Window_GetElement(window,OxO872e[38],true);var sel_float=Window_GetElement(window,OxO872e[39],true);var inp_tooltip=Window_GetElement(window,OxO872e[40],true);function insertOneRow(Ox61f,Ox414){var Ox386=Ox61f.insertRow(-1);for(var i=0;i<Ox414;i++){Ox386.insertCell();} ;} ;btn_insthead[OxO872e[41]]=function btn_insthead_onclick(){if(element[OxO872e[42]]){element.deleteTHead();} else {var Ox621=Table_GetColCount(element);var Ox622=element.createTHead();insertOneRow(Ox622,Ox621);} ;} ;btn_instfoot[OxO872e[41]]=function btn_instfoot_onclick(){if(element[OxO872e[43]]){element.deleteTFoot();} else {var Ox621=Table_GetColCount(element);var Ox624=element.createTFoot();insertOneRow(Ox624,Ox621);} ;} ;btn_editcaption[OxO872e[41]]=function btn_editcaption_onclick(){var Ox626=element[OxO872e[44]];if(Ox626!=null){var Ox282=editor.EditInWindow(Ox626.innerHTML,window);if(Ox282!=null&&Ox282!==false){Ox626[OxO872e[45]]=Ox282;} ;} else {var Ox626=element.createCaption();if(Browser_IsGecko()){Ox626[OxO872e[45]]=OxO872e[46];} else {Ox626[OxO872e[47]]=OxO872e[46];} ;} ;} ;btn_delcaption[OxO872e[41]]=function btn_delcaption_onclick(){if(element[OxO872e[44]]!=null){alert(OxO872e[48]);} ;} ;UpdateState=function UpdateState_Table(){if(Browser_IsGecko()){btn_insthead[OxO872e[45]]=element[OxO872e[42]]?OxO872e[49]:OxO872e[50];btn_instfoot[OxO872e[45]]=element[OxO872e[43]]?OxO872e[49]:OxO872e[50];} else {btn_insthead[OxO872e[47]]=element[OxO872e[42]]?OxO872e[49]:OxO872e[50];btn_instfoot[OxO872e[47]]=element[OxO872e[43]]?OxO872e[49]:OxO872e[50];} ;if(element[OxO872e[44]]!=null){if(Browser_IsGecko()){btn_editcaption[OxO872e[45]]=OxO872e[51];} else {btn_editcaption[OxO872e[47]]=OxO872e[51];} ;btn_editcaption[OxO872e[53]][OxO872e[52]]=OxO872e[54];btn_delcaption[OxO872e[55]]=false;} else {if(Browser_IsGecko()){btn_editcaption[OxO872e[45]]=OxO872e[50];} else {btn_editcaption[OxO872e[47]]=OxO872e[50];} ;btn_delcaption[OxO872e[55]]=true;} ;} ;var t_inp_width=OxO872e[0];var t_inp_height=OxO872e[0];SyncToView=function SyncToView_Table(){inp_cellspacing[OxO872e[56]]=element.getAttribute(OxO872e[57])||OxO872e[0];inp_cellpadding[OxO872e[56]]=element.getAttribute(OxO872e[58])||OxO872e[0];inp_id[OxO872e[56]]=element.getAttribute(OxO872e[59])||OxO872e[0];inp_border[OxO872e[56]]=element.getAttribute(OxO872e[60])||OxO872e[0];inp_bordercolor[OxO872e[56]]=element.getAttribute(OxO872e[61])||OxO872e[0];inp_bordercolor[OxO872e[53]][OxO872e[62]]=inp_bordercolor[OxO872e[56]];inp_bgcolor[OxO872e[56]]=element.getAttribute(OxO872e[63])||element[OxO872e[53]][OxO872e[62]];inp_bgcolor[OxO872e[53]][OxO872e[62]]=inp_bgcolor[OxO872e[56]];inp_collapse[OxO872e[64]]=element[OxO872e[53]][OxO872e[65]]==OxO872e[66];sel_rules[OxO872e[56]]=element.getAttribute(OxO872e[67])||OxO872e[0];inp_summary[OxO872e[56]]=element.getAttribute(OxO872e[68])||OxO872e[0];inp_class[OxO872e[56]]=element[OxO872e[69]]||OxO872e[0];if(element.getAttribute(OxO872e[70])){t_inp_width=element.getAttribute(OxO872e[70]);} else {if(element[OxO872e[53]][OxO872e[70]]){t_inp_width=element[OxO872e[53]][OxO872e[70]];} ;} ;if(t_inp_width){inp_width[OxO872e[56]]=ParseFloatToString(t_inp_width);for(var i=0;i<sel_width_unit[OxO872e[71]][OxO872e[6]];i++){var Ox142=sel_width_unit[OxO872e[71]][i][OxO872e[56]];if(Ox142&&t_inp_width.indexOf(Ox142)!=-1){sel_width_unit[OxO872e[72]]=i;break ;} ;} ;} ;if(element.getAttribute(OxO872e[73])){t_inp_height=element.getAttribute(OxO872e[73]);} else {if(element[OxO872e[53]][OxO872e[73]]){t_inp_height=element[OxO872e[53]][OxO872e[73]];} ;} ;if(t_inp_height){inp_height[OxO872e[56]]=ParseFloatToString(t_inp_height);for(var i=0;i<sel_height_unit[OxO872e[71]][OxO872e[6]];i++){var Ox142=sel_height_unit[OxO872e[71]][i][OxO872e[56]];if(Ox142&&t_inp_height.indexOf(Ox142)!=-1){sel_height_unit[OxO872e[72]]=i;break ;} ;} ;} ;sel_align[OxO872e[56]]=element[OxO872e[74]];if(Browser_IsWinIE()){sel_float[OxO872e[56]]=element[OxO872e[53]][OxO872e[75]];} else {sel_float[OxO872e[56]]=element[OxO872e[53]][OxO872e[76]];} ;sel_textalign[OxO872e[56]]=element[OxO872e[53]][OxO872e[77]];inp_tooltip[OxO872e[56]]=element[OxO872e[78]];} ;SyncTo=function SyncTo_Table(element){if(Browser_IsWinIE()){element[OxO872e[61]]=inp_bordercolor[OxO872e[56]];} else {element.setAttribute(OxO872e[79],inp_bordercolor.value);} ;if(inp_bgcolor[OxO872e[56]]){if(element[OxO872e[53]][OxO872e[62]]){element[OxO872e[53]][OxO872e[62]]=inp_bgcolor[OxO872e[56]];} else {element[OxO872e[63]]=inp_bgcolor[OxO872e[56]];} ;} else {element.removeAttribute(OxO872e[63]);} ;element[OxO872e[53]][OxO872e[65]]=inp_collapse[OxO872e[64]]?OxO872e[66]:OxO872e[0];element[OxO872e[67]]=sel_rules[OxO872e[56]]||OxO872e[0];element[OxO872e[68]]=inp_summary[OxO872e[56]];element[OxO872e[69]]=inp_class[OxO872e[56]];element[OxO872e[57]]=inp_cellspacing[OxO872e[56]];element[OxO872e[58]]=inp_cellpadding[OxO872e[56]];var Ox375=/[^a-z\d]/i;if(Ox375.test(inp_id.value)){alert(OxO872e[80]);return ;} ;element[OxO872e[59]]=inp_id[OxO872e[56]];if(inp_border[OxO872e[56]]==OxO872e[0]){element[OxO872e[60]]=OxO872e[81];} else {element[OxO872e[60]]=inp_border[OxO872e[56]];} ;if(inp_width[OxO872e[56]]==OxO872e[0]){element.removeAttribute(OxO872e[70]);element[OxO872e[53]][OxO872e[70]]=OxO872e[0];} else {try{t_inp_width=inp_width[OxO872e[56]];if(sel_width_unit[OxO872e[56]]==OxO872e[82]){t_inp_width=inp_width[OxO872e[56]]+sel_width_unit[OxO872e[56]];} ;if(element[OxO872e[53]][OxO872e[70]]&&element[OxO872e[70]]){element[OxO872e[53]][OxO872e[70]]=t_inp_width;element[OxO872e[70]]=t_inp_width;} else {if(element[OxO872e[53]][OxO872e[70]]){element[OxO872e[53]][OxO872e[70]]=t_inp_width;} else {element[OxO872e[70]]=t_inp_width;} ;} ;} catch(x){} ;} ;if(inp_height[OxO872e[56]]==OxO872e[0]){element.removeAttribute(OxO872e[73]);element[OxO872e[53]][OxO872e[73]]=OxO872e[0];} else {try{t_inp_height=inp_height[OxO872e[56]];if(sel_height_unit[OxO872e[56]]==OxO872e[82]){t_inp_height=inp_height[OxO872e[56]]+sel_height_unit[OxO872e[56]];} ;t_inp_height=inp_height[OxO872e[56]]+sel_height_unit[OxO872e[56]];if(element[OxO872e[53]][OxO872e[73]]&&element[OxO872e[73]]){element[OxO872e[53]][OxO872e[73]]=t_inp_height;element[OxO872e[73]]=t_inp_height;} else {if(element[OxO872e[53]][OxO872e[73]]){element[OxO872e[53]][OxO872e[73]]=t_inp_height;} else {element[OxO872e[73]]=t_inp_height;} ;} ;} catch(x){} ;} ;element[OxO872e[74]]=sel_align[OxO872e[56]];if(Browser_IsWinIE()){element[OxO872e[53]][OxO872e[75]]=sel_float[OxO872e[56]];} else {element[OxO872e[53]][OxO872e[76]]=sel_float[OxO872e[56]];} ;element[OxO872e[53]][OxO872e[77]]=sel_textalign[OxO872e[56]];element[OxO872e[78]]=inp_tooltip[OxO872e[56]];if(element[OxO872e[78]]==OxO872e[0]){element.removeAttribute(OxO872e[78]);} ;if(element[OxO872e[68]]==OxO872e[0]){element.removeAttribute(OxO872e[68]);} ;if(element[OxO872e[69]]==OxO872e[0]){element.removeAttribute(OxO872e[69]);} ;if(element[OxO872e[69]]==OxO872e[0]){element.removeAttribute(OxO872e[83]);} ;if(element[OxO872e[59]]==OxO872e[0]){element.removeAttribute(OxO872e[59]);} ;if(element[OxO872e[74]]==OxO872e[0]){element.removeAttribute(OxO872e[74]);} ;if(element[OxO872e[67]]==OxO872e[0]){element.removeAttribute(OxO872e[67]);} ;} ;inp_bgcolor[OxO872e[41]]=function inp_bgcolor_onclick(){SelectColor(inp_bgcolor);} ;inp_bordercolor[OxO872e[41]]=function inp_bordercolor_onclick(){SelectColor(inp_bordercolor);} ;if(!Browser_IsWinIE()){Window_GetElement(window,OxO872e[84],true)[OxO872e[53]][OxO872e[52]]=OxO872e[54];} ;