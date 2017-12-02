//$(function () {

//    $('#contact_purpose').click(function () {
//        if ($(this).val() == 'employment') {
//            $('.employment_display').show(); //css("display", "block");
//        }
//        else {
//            $('.employment_display').hide(); //css("display", "none");
//        }
//    });
//});




$(function () {
	$("#Link").click(function () {
		$("#hidden").css("display", "block");
	});
	$("#Remove").click(function () {
		$("#hidden").css("display", "none");

	});
});