
// ÜYE KAYIT SAYFASI İÇİN 

function kontrol(){
    var eposta = document.getElementById("eposta").value;
    var kullaniciadi = document.getElementById("kullaniciadi").value;
    var parola = document.getElementById("parola").value;

    
    if(kullaniciadi.length < 6){
        alert("Kullanıcı adı 6 karakterden kısa olamaz.");
    }
    
    else if(parola.length < 6){
        alert("Parola 6 karakterden kısa olmaz.");
    }
    
    var simge = eposta.indexOf("@");
    if(simge == -1){
        alert("E-postada '@' karakteri bulunmalıdır.")
    }

    else{
        alert("Kaydınız başarıyla tamamlanmıştır.")
    }

}


// ÜYE GİRİŞ SAYFASI İÇİN


