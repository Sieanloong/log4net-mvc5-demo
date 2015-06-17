$(document).ready(function () {
    // Init bootstrap switch widgets
    $('#email-error-log').bootstrapSwitch();
    $('.loop-toggle').bootstrapSwitch();

    // Attach EH for monitoring chg evt of email toggle state
    $('input#email-error-log').on('switchChange.bootstrapSwitch', function (event, state) {
        FireEmailChgEvent(state ? 1 : 2)
    });

    // Attach EH for monitoring chg evt of loop toggle state
    $('input.loop-toggle').on('switchChange.bootstrapSwitch', function (event, state) {
        FireEventLoop($(this).attr('data-evt-code'), state ? 1 : 2)
    });
});

function FireEvent(evtCode) {
    $.get('/Static/FireEvent', { evtCode: evtCode});
}

function FireEventLoop(evtCode, state) {
    $.get('/Loop/FireEventLoop', { evtCode: evtCode, runState: state});
}

function FireEmailChgEvent(state) {
    $.get('/Home/SetEmailFlag', { state: state });
}