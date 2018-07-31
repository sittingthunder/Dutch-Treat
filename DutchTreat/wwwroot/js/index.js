$(document).ready(function () {
    var x = 0;
    var s = "";

    console.log("Hello Pluralsight");



    var theform = $("#theform");
    theform.hide();

    var buybutton = $("#buybutton");
    buybutton.on("click", function () {
        console.log("Buying item");
    });

    var productInfo = $(".product-props li");
    //var listItems = productInfo.item[0].children;
    productInfo.on("click", function () {
        console.log("You clicked on " + $(this).text());
    });

    var $loginToggle = $("#loginToggle");
    var $popupForm = $(".popup-form");

    $loginToggle.on("click", function () {
        $popupForm.fadeToggle(500);
    });
});