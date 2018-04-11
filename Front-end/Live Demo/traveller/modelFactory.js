const modelFactoryFunc = function (){
    const journeyToString = function () {
        return `Journey ----<br />
                Start location: ${this.startingLocation}<br />
                Destination: ${this.destination}<br />
                Distance: ${this.distance}`
    }

    const createJourney = function (startingLocation, destination, distance){
        return {
            get startingLocation(){
                return startingLocation
            },
            get destination(){
                return destination
            },
            get distance(){
                return distance
            },
            toString: journeyToString 
        }
    }

    const ticketToString = function () {
        return `Ticket ----<br />
                Destination: ${this.journey.destination}`
    }

    const createTicket = function (journey) {
        return {
            get journey() {
                return journey
            },
            toString: ticketToString
        }
    }
 
    return {
        createJourney,
        createTicket
    }
}