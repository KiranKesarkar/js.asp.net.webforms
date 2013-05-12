function ShowMessage(msg) {
    var div = document.createElement("div");
    div.innerText = "Message From ShowMessage.js: " + msg;
    document.body.appendChild(div);
}