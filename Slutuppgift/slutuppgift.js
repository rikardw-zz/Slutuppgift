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