

var description = document.getElementById("pills-description-tab");
var payment = document.getElementById("pills-payment-methods-tab");
var comment = document.getElementById("pills-comment-tab");

description.addEventListener("click", function(){
    description.style.borderBottom = "1px solid red"; 
    description.style.color = "red";
    payment.style.borderBottom = "none";
    payment.style.color = "black";
    comment.style.borderBottom = "none";
    comment.style.color = "black";
});


payment.addEventListener("click",function(){
    payment.style.borderBottom = "1px solid red"; 
    payment.style.color = "Red";
    description.style.borderBottom="none"; 
    comment.style.borderBottom="none"; 
    description.style.color="black";
    comment.style.color="black";
});

comment.addEventListener("click",function(){
    comment.style.borderBottom = "1px solid red"; 
    comment.style.color = "Red";
    payment.style.borderBottom="none"; 
    description.style.borderBottom="none";
    payment.style.color="black";
    description.style.color="black";
});