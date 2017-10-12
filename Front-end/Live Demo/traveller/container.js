const container = (function(){
    const modelFactory = modelFactoryFunc()
    const database = databaseFunc()
    const commands = commandsFunc(modelFactory, database)
    const commandProcessor = commandProcessorFunc(commands)

    return {
        commandProcessor
    }
}())