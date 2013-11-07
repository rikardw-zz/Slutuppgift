$(function () {
    $(function () {
        $("#ContentPlaceHolder1_datum").datepicker({
            inline: true,
            monthNames: ["Januari", "Februari", "Mars", "April", "Maj", "Juni", "Juli", "Augusti", "September", "Oktober", "November", "December"],
            dayNamesMin: ["Sön", "Mån", "Tis", "Ons", "Tors", "Fre", "Lör"],
            dateFormat: "yy-mm-dd",
            firstDay: 1
        });
    });
});

/*
Denna fungerar inte som den ska

$(function () {
    $("ContentPlaceHolder1").validate({
        rules: {
            lbjaktlag: { required: true, lettersonly: true },
            skytt: { required: true, lettersonly: true, maxlength: 20 }
            
        },
        messages: {
            lbjaktlag: { required: 'Ange förnamn', lettersonly: 'Ange endast bokstäver' },
            skytt: { required: 'Ange efternamn', lettersonly: 'Ange endast bokstäver' },
            age: { required: 'Ange ålder', digits: 'Ange endast siffror', min: 'Minimum 18 år', max: 'Max 45 år', maxlength: 'Ange ålder' },
            username: { required: 'Ange ett användarnamn', maxlength: 'Max 10 tecken' },
            password1: { required: 'Lösenord måste anges', minlength: 'Minst 6 tecken', maxlength: 'Max 10 tecken' },
            password2: { required: 'Du måste ange samma lösenord som ovan', equalTo: 'Du måste ange samma lösenord som ovan', minlength: 'Minst 6 tecken', maxlength: 'Max 10 tecken' },
            useremail: { required: 'Du måste ange en giltig E-postadress', email: 'Du måste ange en giltig e-postadress' },
            datepicker: { required: 'Du måste ange ett datum', date: 'Ange datum via kalendern' }
        }

    });
});

*/