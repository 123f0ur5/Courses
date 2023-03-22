$(".continue").on("click", function(){ //$(".continue, .round-tab").on("click", function(){
    completed = true
    active_form = $("div > .active")
    console.log(active_form)
    active_tab = $(".nav > li.active ")
    current = parseInt(active_tab.children().attr("aria-controls"))
    // target = parseInt($(this).parent().attr("aria-controls"))
    fields = active_form.children("div > .row").children()

    // console.log(current, target)
    // if (target){
    //     if (current > target) {
    //         active_tab.removeClass("active")
    //         $(this).parent().parent().addClass("active")
            
    //     }
    // }


    for (i = 0; i < fields.length; i++) {
        campo = fields[i].children[0].children[1]
        if(campo.value == ""){
            alert(`Favor preencher o ${campo.name} corretamente!`);
            completed = false
            break
        }
    };

    if (completed) {
        active_form.removeClass("active")
        active_form.parent().find(`#${current+1}`).addClass("active")
        active_tab.removeClass("active")
        $(`[aria-controls=${current+1}]`).parent().removeClass("disabled").addClass("active")
    }
})

$(".prev-step").on("click", function(){
    active_form = $("div > .active")
    active_tab = $(".nav > li.active ")
    current = parseInt(active_tab.children().attr("aria-controls"))

    active_form.removeClass("active")
    active_form.parent().find(`#${current-1}`).addClass("active")
    active_tab.removeClass("active")
    $(`[aria-controls=${current-1}]`).parent().removeClass("disabled").addClass("active")
})

console.log($("[rafa=caralho]"))