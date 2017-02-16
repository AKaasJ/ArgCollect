// Write your Javascript code.

$(function(){
    $("#argumentDiv").hide();
    $("#buttonsDiv").show();
});

$("#agreeButton").click(function () {
    $("#argumentDiv").show();
    $("#primerArea").val("Prime for agree");
    $("#buttonsDiv").hide();
});

$("#disagreeButton").click(function () {
    $("#argumentDiv").show();
    $("#primerArea").val("Prime for disagree");
    $("#buttonsDiv").hide();
});