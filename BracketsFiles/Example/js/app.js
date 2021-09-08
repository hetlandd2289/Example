
            
            

function showMessage(){
    alert("Page Loaded");


    var soc = getSoc();
}

function getSoc(string soc) {
    var soc = "";
    while (soc.length != 9){
        soc = prompt("What is your Social Security Number?");
    }
    return soc;
}