var OxO146e=["outer","btnbrowse","inp_src","onclick","value","cssText","style","src","FileName"];var outer=Window_GetElement(window,OxO146e[0],true);var btnbrowse=Window_GetElement(window,OxO146e[1],true);var inp_src=Window_GetElement(window,OxO146e[2],true);btnbrowse[OxO146e[3]]=function btnbrowse_onclick(){function Ox35c(Ox13e){if(Ox13e){inp_src[OxO146e[4]]=Ox13e;} ;} ;editor.SetNextDialogWindow(window);editor.ShowSelectFileDialog(Ox35c,inp_src.value);} ;UpdateState=function UpdateState_Media(){outer[OxO146e[6]][OxO146e[5]]=element[OxO146e[6]][OxO146e[5]];outer.mergeAttributes(element);if(element[OxO146e[7]]){outer[OxO146e[8]]=element[OxO146e[8]];} else {outer.removeAttribute(OxO146e[8]);} ;} ;SyncToView=function SyncToView_Media(){inp_src[OxO146e[4]]=element[OxO146e[8]];} ;SyncTo=function SyncTo_Media(element){element[OxO146e[8]]=inp_src[OxO146e[4]];} ;