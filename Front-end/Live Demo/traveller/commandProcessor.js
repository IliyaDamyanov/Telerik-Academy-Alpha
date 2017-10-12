const commandProcessorFunc = function (commands){
    const processCommand = function (commandText){
        const params = commandText.split(' ')
        const commandName = params[0]
        params.shift()
        const command = commands.find((command) => command.name === commandName)
        if (command === undefined){
            throw `Command ${commandName} is not defined!`
        }

        return command.execute(params)
    }

    return {
        processCommand
    }
}