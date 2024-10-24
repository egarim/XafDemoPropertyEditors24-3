

let blazorInstance;

function registerBlazorInstance(instance) {
    blazorInstance = instance; // Store the instance for later use
}

function InitJQuerySlider(CurrentValue) {
 

    $(function () {
        $("#slider").slider({
            // Trigger when the slider is being moved
            slide: function (event, ui) {
                // Update the current value while sliding
                $("#slider-value").text(ui.value);
            },
            value: CurrentValue,
            // Trigger when the slider has finished moving
            change: function (event, ui) {
                // Update the current value when the slider value changes
                $("#slider-value").text(ui.value);
                if (blazorInstance) {
                    blazorInstance.invokeMethodAsync('ReceiveValueFromJsInstance', ui.value);
                }
            }
        });
    });
}