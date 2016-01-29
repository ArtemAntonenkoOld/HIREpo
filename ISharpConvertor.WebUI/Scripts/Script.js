$(document).ready(function() {
    $(".username").focus(function() {
        $(".user-icon").css("left","-48px");
    });
    $(".username").blur(function() {
        $(".user-icon").css("left","0px");
    });
	
    $(".password").focus(function() {
        $(".pass-icon").css("left","-48px");
    });
    $(".password").blur(function() {
        $(".pass-icon").css("left","0px");
    });
    chis = 0;
    $(".identity").click(function () {
        if (chis == 0) {
            $("#wrapper_r").css("display", "block"); chis = 1; valid=
        } else {
            $("#wrapper_r").css("display", "none");
            chis = 0;
        }

    });
});