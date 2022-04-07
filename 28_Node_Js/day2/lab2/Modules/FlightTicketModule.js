/* Task1
Create your own module that can be used in flight tickets reservation
o Let the flight ticket contains info about 
seat num, 
flight num, 
departure and arrival airports
Travelling date.
o User can display, get and update info of his ticket
*/
class FlightTicket
{
    constructor(_SeatNum,_FlightNum,_Departure,_Arrival,_Date,_id)
    {
         //properties 
        this.SeatNum = _SeatNum;
        this.FlightNum = _FlightNum;
        this.Departure = _Departure;
        this.Arrival = _Arrival;
        this.TicktDate = _Date;
        this.id = _id;
    }

}
class FlightTickets{

    Tickets = [];
    ID = 0;
    // constructor()
    // {
    //     this.Tickets = [];
    //     this.ID = 0;
    // }
    CreateTicket(SeatNum,FlightNum,Departure,Arrival,Date){
    
        this.Tickets.push(new FlightTicket(SeatNum,FlightNum,Departure,Arrival,Date,this.ID));
        this.ID++;
        return this.Tickets[this.ID-1].id;
    }
    
   
    getTicket(TickedID){
        return this.Tickets[TickedID];
    }

    displayTicket(TickedID){
    let ticket = this.Tickets[TickedID];
    console.log("SeatNum: "+ticket.SeatNum);
    console.log("FlightNum: "+ticket.FlightNum);
    console.log("Departure: "+ticket.Departure);
    console.log("Arrival: "+ticket.Arrival);
    console.log("Date: "+ticket.TicktDate);
}

    UpdateTicketseat(TickedID,_SeatNum){
    this.Tickets[TickedID].SeatNum = _SeatNum;
}

    UpdateTicketFlightNum(TickedID,_FlightNum){
    this.Tickets[TickedID].FlightNum = _FlightNum;
}
    UpdateTicketDepatual(TickedID,_Departure){
    this.Tickets[TickedID].Departure = _Departure;
}
    UpdateTicketArrival(TickedID,_Arrival){
    this.Tickets[TickedID].Arrival = _Arrival;
 }
    UpdateTicketDate(TickedID,_Date){
    this.Tickets[TickedID].TicktDate = _Date;
}

}





module.exports = new FlightTickets();