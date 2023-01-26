$("#btnSend").click( function () {
    alert("From: " + $("#txtFrom").val() +
        "\nSubject: " + $("#txtSubj").val() +
        "\nMessage: " + $("#txtMessage").val());

    $("#picGanderson").fadeToggle();
})

