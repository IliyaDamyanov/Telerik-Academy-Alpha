$(function(){
    $('input:button').on('click', () => {
        const textField = $('#textInput')
        const result = $('#resultElement')

        const commandText = textField.val()
        let commandResult
        try {
            commandResult = container.commandProcessor.processCommand(commandText)            
        }
        catch (ex) {
            commandResult = ex
        }

        result.append(commandResult + '<br />')
    })
})