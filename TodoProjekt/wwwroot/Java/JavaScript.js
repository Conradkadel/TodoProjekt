

var screen = 0

function hideAppear(id)
{

    var div = document.getElementById('appear ' + id)

    if (screen == 1) {
        div.classList.add("animate");
        setTimeout(function () {
            div.classList.remove("animate");
        }, 400);
        div.style.display = "block";
        screen = 0
    }
    else
    {
       div.classList.add("animateback");
          setTimeout(function () {
              div.classList.remove("animateback");
              div.style.display = "none";
            }, 400);

        
        screen = 1
        
    }
    

}