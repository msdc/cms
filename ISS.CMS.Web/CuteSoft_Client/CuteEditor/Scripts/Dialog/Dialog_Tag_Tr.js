var OxOa0a2=["inp_width","inp_height","sel_align","sel_valign","inp_bgColor","inp_borderColor","inp_borderColorLight","inp_borderColorDark","inp_class","inp_id","inp_tooltip","value","bgColor","backgroundColor","style","id","borderColor","borderColorLight","borderColorDark","className","width","height","align","vAlign","title","[[ValidNumber]]","[[ValidID]]","","class","valign","onclick"];var inp_width=Window_GetElement(window,OxOa0a2[0],true);var inp_height=Window_GetElement(window,OxOa0a2[1],true);var sel_align=Window_GetElement(window,OxOa0a2[2],true);var sel_valign=Window_GetElement(window,OxOa0a2[3],true);var inp_bgColor=Window_GetElement(window,OxOa0a2[4],true);var inp_borderColor=Window_GetElement(window,OxOa0a2[5],true);var inp_borderColorLight=Window_GetElement(window,OxOa0a2[6],true);var inp_borderColorDark=Window_GetElement(window,OxOa0a2[7],true);var inp_class=Window_GetElement(window,OxOa0a2[8],true);var inp_id=Window_GetElement(window,OxOa0a2[9],true);var inp_tooltip=Window_GetElement(window,OxOa0a2[10],true);SyncToView=function SyncToView_Tr(){inp_bgColor[OxOa0a2[11]]=element.getAttribute(OxOa0a2[12])||element[OxOa0a2[14]][OxOa0a2[13]];inp_id[OxOa0a2[11]]=element.getAttribute(OxOa0a2[15]);inp_bgColor[OxOa0a2[14]][OxOa0a2[13]]=inp_bgColor[OxOa0a2[11]];inp_borderColor[OxOa0a2[11]]=element.getAttribute(OxOa0a2[16]);inp_borderColor[OxOa0a2[14]][OxOa0a2[13]]=inp_borderColor[OxOa0a2[11]];inp_borderColorLight[OxOa0a2[11]]=element.getAttribute(OxOa0a2[17]);inp_borderColorLight[OxOa0a2[14]][OxOa0a2[13]]=inp_borderColorLight[OxOa0a2[11]];inp_borderColorDark[OxOa0a2[11]]=element.getAttribute(OxOa0a2[18]);inp_borderColorDark[OxOa0a2[14]][OxOa0a2[13]]=inp_borderColorDark[OxOa0a2[11]];inp_class[OxOa0a2[11]]=element[OxOa0a2[19]];inp_width[OxOa0a2[11]]=element.getAttribute(OxOa0a2[20])||element[OxOa0a2[14]][OxOa0a2[20]];inp_height[OxOa0a2[11]]=element.getAttribute(OxOa0a2[21])||element[OxOa0a2[14]][OxOa0a2[21]];sel_align[OxOa0a2[11]]=element.getAttribute(OxOa0a2[22]);sel_valign[OxOa0a2[11]]=element.getAttribute(OxOa0a2[23]);inp_tooltip[OxOa0a2[11]]=element.getAttribute(OxOa0a2[24]);} ;SyncTo=function SyncTo_Tr(element){if(inp_bgColor[OxOa0a2[11]]){if(element[OxOa0a2[14]][OxOa0a2[13]]){element[OxOa0a2[14]][OxOa0a2[13]]=inp_bgColor[OxOa0a2[11]];} else {element[OxOa0a2[12]]=inp_bgColor[OxOa0a2[11]];} ;} else {element.removeAttribute(OxOa0a2[12]);} ;element[OxOa0a2[16]]=inp_borderColor[OxOa0a2[11]];element[OxOa0a2[17]]=inp_borderColorLight[OxOa0a2[11]];element[OxOa0a2[18]]=inp_borderColorDark[OxOa0a2[11]];element[OxOa0a2[19]]=inp_class[OxOa0a2[11]];if(element[OxOa0a2[14]][OxOa0a2[20]]||element[OxOa0a2[14]][OxOa0a2[21]]){try{element[OxOa0a2[14]][OxOa0a2[20]]=inp_width[OxOa0a2[11]];element[OxOa0a2[14]][OxOa0a2[21]]=inp_height[OxOa0a2[11]];} catch(er){alert(OxOa0a2[25]);} ;} else {try{element[OxOa0a2[20]]=inp_width[OxOa0a2[11]];element[OxOa0a2[21]]=inp_height[OxOa0a2[11]];} catch(er){alert(OxOa0a2[25]);} ;} ;var Ox375=/[^a-z\d]/i;if(Ox375.test(inp_id.value)){alert(OxOa0a2[26]);return ;} ;element[OxOa0a2[22]]=sel_align[OxOa0a2[11]];element[OxOa0a2[15]]=inp_id[OxOa0a2[11]];element[OxOa0a2[23]]=sel_valign[OxOa0a2[11]];element[OxOa0a2[24]]=inp_tooltip[OxOa0a2[11]];if(element[OxOa0a2[15]]==OxOa0a2[27]){element.removeAttribute(OxOa0a2[15]);} ;if(element[OxOa0a2[12]]==OxOa0a2[27]){element.removeAttribute(OxOa0a2[12]);} ;if(element[OxOa0a2[16]]==OxOa0a2[27]){element.removeAttribute(OxOa0a2[16]);} ;if(element[OxOa0a2[17]]==OxOa0a2[27]){element.removeAttribute(OxOa0a2[17]);} ;if(element[OxOa0a2[7]]==OxOa0a2[27]){element.removeAttribute(OxOa0a2[7]);} ;if(element[OxOa0a2[19]]==OxOa0a2[27]){element.removeAttribute(OxOa0a2[19]);} ;if(element[OxOa0a2[19]]==OxOa0a2[27]){element.removeAttribute(OxOa0a2[28]);} ;if(element[OxOa0a2[22]]==OxOa0a2[27]){element.removeAttribute(OxOa0a2[22]);} ;if(element[OxOa0a2[23]]==OxOa0a2[27]){element.removeAttribute(OxOa0a2[29]);} ;if(element[OxOa0a2[24]]==OxOa0a2[27]){element.removeAttribute(OxOa0a2[24]);} ;if(element[OxOa0a2[20]]==OxOa0a2[27]){element.removeAttribute(OxOa0a2[20]);} ;if(element[OxOa0a2[21]]==OxOa0a2[27]){element.removeAttribute(OxOa0a2[21]);} ;} ;inp_borderColor[OxOa0a2[30]]=function inp_borderColor_onclick(){SelectColor(inp_borderColor);} ;inp_bgColor[OxOa0a2[30]]=function inp_bgColor_onclick(){SelectColor(inp_bgColor);} ;inp_borderColorLight[OxOa0a2[30]]=function inp_borderColorLight_onclick(){SelectColor(inp_borderColorLight);} ;inp_borderColorDark[OxOa0a2[30]]=function inp_borderColorDark_onclick(){SelectColor(inp_borderColorDark);} ;