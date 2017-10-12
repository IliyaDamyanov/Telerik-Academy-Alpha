const commandsFunc = function (modelFactory, database){
    const createTicketCommand = {
        get name() {
            return 'createticket'
        },
        execute: (parameters) => {

            const journeyId = parameters[0]
            const journey = database.journeys[journeyId]

            const ticket = modelFactory.createTicket(journey)
            database.tickets.push(ticket)

            return `Ticket with ID ${database.tickets.length - 1} was created.`
        }
    }

    const createJourneyCommand = {
        get name() {
            return 'createjourney'
        },
        execute: (parameters) => {

            const startLocation = parameters[0];
            const destination = parameters[1];
            const distance = parameters[2];

            const journey = modelFactory.createJourney(startLocation, destination, distance)
            database.journeys.push(journey)

            return `Journey with ID ${database.journeys.length - 1} was created.`
        }
    }

    const listJourneys = {
        get name() {
            return 'listjourney'
        },
        execute: (parameters) => {
            return database.journeys.length ? database.journeys.join('<br />') : 'No journeys added!'
        }
    }

    return [createTicketCommand, createJourneyCommand, listJourneys]
}