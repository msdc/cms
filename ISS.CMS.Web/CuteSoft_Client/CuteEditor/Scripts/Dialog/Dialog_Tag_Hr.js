var OxO1aba=["inp_width","eenheid","alignment","hrcolor","hrcolorpreview","shade","sel_size","width","style","value","px","%","size","align","color","backgroundColor","noShade","noshade","","onclick"];var inp_width=Window_GetElement(window,OxO1aba[0],true);var eenheid=Window_GetElement(window,OxO1aba[1],true);var alignment=Window_GetElement(window,OxO1aba[2],true);var hrcolor=Window_GetElement(window,OxO1aba[3],true);var hrcolorpreview=Window_GetElement(window,OxO1aba[4],true);var shade=Window_GetElement(window,OxO1aba[5],true);var sel_size=Window_GetElement(window,OxO1aba[6],true);UpdateState=function UpdateState_Hr(){} ;SyncToView=function SyncToView_Hr(){if(element[OxO1aba[8]][OxO1aba[7]]){if(element[OxO1aba[8]][OxO1aba[7]].search(/%/)<0){eenheid[OxO1aba[9]]=OxO1aba[10];inp_width[OxO1aba[9]]=element[OxO1aba[8]][OxO1aba[7]].split(OxO1aba[10])[0];} else {eenheid[OxO1aba[9]]=OxO1aba[11];inp_width[OxO1aba[9]]=element[OxO1aba[8]][OxO1aba[7]].split(OxO1aba[11])[0];} ;} ;sel_size[OxO1aba[9]]=element[OxO1aba[12]];alignment[OxO1aba[9]]=element[OxO1aba[13]];hrcolor[OxO1aba[9]]=element[OxO1aba[14]];if(element[OxO1aba[14]]){hrcolor[OxO1aba[8]][OxO1aba[15]]=element[OxO1aba[14]];} ;if(element[OxO1aba[16]]){shade[OxO1aba[9]]=OxO1aba[17];} else {shade[OxO1aba[9]]=OxO1aba[18];} ;} ;SyncTo=function SyncTo_Hr(element){if(sel_size[OxO1aba[9]]){element[OxO1aba[12]]=sel_size[OxO1aba[9]];} ;if(hrcolor[OxO1aba[9]]){element[OxO1aba[14]]=hrcolor[OxO1aba[9]];} ;if(alignment[OxO1aba[9]]){element[OxO1aba[13]]=alignment[OxO1aba[9]];} ;if(shade[OxO1aba[9]]==OxO1aba[17]){element[OxO1aba[16]]=true;} else {element[OxO1aba[16]]=false;} ;if(inp_width[OxO1aba[9]]){element[OxO1aba[8]][OxO1aba[7]]=inp_width[OxO1aba[9]]+eenheid[OxO1aba[9]];} ;} ;hrcolor[OxO1aba[19]]=hrcolorpreview[OxO1aba[19]]=function hrcolor_onclick(){SelectColor(hrcolor,hrcolorpreview);} ;