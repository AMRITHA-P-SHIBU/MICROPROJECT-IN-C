#include <stdio.h>
#include <string.h>
struct TouristSpot {
    char name[50];
    char description[200];
};
struct Hotel {
    char name[50];
    char location[50];
    float price;
};
struct TravelAgency {
    char name[50];
    char contact[50];
    char services[100];
};
void displayTouristSpots(struct TouristSpot spots[], int count);
void displayHotels(int locationChoice);
void displayTravelAgencies(int locationChoice);
int main() {
    struct TouristSpot spots[10] = {
        {"Munnar", "A picturesque hill station with tea plantations."},
        {"Alleppey", "Famous for its backwaters and houseboat cruises."},
        {"Kochi", "A vibrant city with historical sites and cultural heritage."},
        {"Thekkady", "Home to Periyar National Park and wildlife experiences."},
        {"Vagamon", "Known for its lush green meadows and tranquil landscapes."},
        {"Kumarakom", "A serene backwater destination with beautiful houseboats."},
        {"Wayanad", "Famous for its wildlife sanctuaries and green landscapes."},
        {"Kovalam", "A popular beach destination known for its sandy shores."},
        {"Athirappilly", "Known as the Niagara of India, with beautiful waterfalls."},
        {"Bekal", "Famous for its historic fort and stunning beach."}
    };
    int choice;
    while (1) {
        printf("\nTourist Information System - Kerala\n");
        printf("1. View Tourist Spots\n");
        printf("2. View Hotels\n");
        printf("3. View Travel Agencies\n");
        printf("4. Exit\n");
        printf("Enter your choice: ");
        scanf("%d", &choice);
        switch (choice) {
            case 1:
                displayTouristSpots(spots, 10);
                break;
            case 2:
                printf("Select a location to view hotels:\n");
                printf("1. Munnar\n2. Alleppey\n3. Kochi\n4. Thekkady\n5. Vagamon\n");
                printf("6. Kumarakom\n7. Wayanad\n8. Kovalam\n9. Athirappilly\n10. Bekal\n");
                printf("Enter your choice: ");
                int locationChoice;
                scanf("%d", &locationChoice);
                displayHotels(locationChoice);
                break;
            case 3:
                printf("Select a location to view travel agencies:\n");
                printf("1. Munnar\n2. Alleppey\n3. Kochi\n4. Thekkady\n5. Vagamon\n");
                printf("6. Kumarakom\n7. Wayanad\n8. Kovalam\n9. Athirappilly\n10. Bekal\n");
                printf("Enter your choice: ");
                scanf("%d", &locationChoice);
                displayTravelAgencies(locationChoice);
                break;
            case 4:
                printf("Exiting the system.THANK YOU!\n");
                return 0;
            default:
                printf("Invalid choice.Please try again.\n");
        }
    }
    return 0;
}
void displayTouristSpots(struct TouristSpot spots[], int count) {
    printf("\nTourist Spots in Kerala:\n");
    for (int i = 0; i < count; i++) {
        printf("%d. %s: %s\n", i + 1, spots[i].name, spots[i].description);
    }
}
void displayHotels(int locationChoice) {
    printf("\nHotels:\n");
    switch (locationChoice) {
        case 1: // Munnar
            printf("1. Munnar Heritage, Price: $1200.00 per head\n");
            printf("2. Green Valley, Price: $1300.00 per head\n");
            printf("3. Hilltop Hotel, Price: $1400.00 per head\n");
            printf("4. Spice Tree, Price: $1600.00 per head\n");
            printf("5. Tea County, Price: $1100.00 per head\n");
            break;
        case 2: // Alappuzha
            printf("1. Alleppey Houseboat, Price: $1500.00 per head\n");
            printf("2. Backwater Retreat, Price: $1400.00 per head\n");
            printf("3. Lake Palace, Price: $1800.00 per head\n");
            printf("4. Alleppey Beach Resort, Price: $1300.00 per head\n");
            printf("5. Coconut Lagoon, Price: $1700.00 per head\n");
            break;
        case 3: // Kochi
            printf("1. Kochi Marriott, Price: $1800.00 per head\n");
            printf("2. Crowne Plaza, Price: $2000.00 per head\n");
            printf("3. Le Meridien, Price: $1900.00 per head\n");
            printf("4. Hotel Fort Queen, Price: $1500.00 per head\n");
            printf("5. Taj Gateway, Price: $2200.00 per head\n");
            break;
        case 4: // Thekkady
            printf("1. Thekkady Resort, Price: $1300.00 per head\n");
            printf("2. Elephant Court, Price: $1400.00 per head\n");
            printf("3. Spice Village, Price: $1600.00 per head\n");
            printf("4. Hotel Ambadi, Price: $1200.00 per head\n");
            printf("5. Greenwoods Resort, Price: $1500.00 per head\n");
            break;
        case 5: // Vagamon
            printf("1. Vagamon Hill Resort, Price: $1000.00 per head\n");
            printf("2. Green Meadows, Price: $1100.00 per head\n");
            printf("3. Vagamon Heights, Price: $1200.00 per head\n");
            printf("4. Pine Valley, Price: $1300.00 per head\n");
            printf("5. Hill View, Price: $1400.00 per head\n");
            break;
        case 6: // Kumarakom
            printf("1. Kumarakom Lake Resort, Price: $2000.00 per head\n");
            printf("2. Coconut Lagoon, Price: $1800.00 per head\n");
            printf("3. Backwater Heritage Resort, Price: $1600.00 per head\n");
            printf("4. Paradise Resorts, Price: $1700.00 per head\n");
            printf("5. Vembanad Lake Resort, Price: $1500.00 per head\n");
            break;
        case 7: // Wayanad
            printf("1. Wayanad Silver Woods, Price: $1400.00 per head\n");
            printf("2. Banasura Hill Resort, Price: $1500.00 per head\n");
            printf("3. Green Castle, Price: $1300.00 per head\n");
            printf("4. Vythiri Resort, Price: $1600.00 per head\n");
            printf("5. Spice Garden Resort, Price: $1200.00 per head\n");
            break;
        case 8: // Kovalam
            printf("1. Kovalam Beach Resort, Price: $1800.00 per head\n");
            printf("2. The Leela Kovalam, Price: $2500.00 per head\n");
            printf("3. Samudra Beach Resort, Price: $2000.00 per head\n");
            printf("4. Sagara Beach Resort, Price: $1600.00 per head\n");
            printf("5. The Turtle on the Beach, Price: $2200.00 per head\n");
            break;
        case 9: // Athirappilly
            printf("1. Athirappilly Waterfalls Resort, Price: $1300.00 per head\n");
            printf("2. Rainforest Resort, Price: $1400.00 per head\n");
            printf("3. Spice Tree Athirappilly, Price: $1600.00 per head\n");
            printf("4. Riverine Resort, Price: $1500.00 per head\n");
            printf("5. Athirappilly Villa, Price: $1100.00 per head\n");
            break;
        case 10: // Bekal
            printf("1. Bekal Fort Resort, Price: $1700.00 per head\n");
            printf("2. The Lalit Resort & Spa, Price: $2000.00 per head\n");
            printf("3. Bekal Paradise, Price: $1300.00 per head\n");
            printf("4. Malabar Beach Resort, Price: $1600.00 per head\n");
            printf("5. Neelakanta Beach Resort, Price: $1400.00 per head\n");
            break;
        default:
            printf("No hotels available for this location.\n");
            break;
    }
}
void displayTravelAgencies(int locationChoice) {
    printf("\nTravel Agencies:\n");
    switch (locationChoice) {
        case 1: // Munnar
            printf("1. Elixir Travels, Contact: 123-456-7890, Services: Tours and packages.\n");
            printf("2. Green Travels, Contact: 234-567-8901, Services: Trekking and transport.\n");
            break;
        case 2: // Alleppey
            printf("1. Alleppey Houseboat Tours, Contact: 345-678-9012, Services: Houseboat rentals.\n");
            printf("2. Backwater Holidays, Contact: 456-789-0123, Services: Backwater tours.\n");
            break;
        case 3: // Kochi
            printf("1. Cochin Travels, Contact: 567-890-1234, Services: City tours.\n");
            printf("2. Kochi Trip Planners, Contact: 678-901-2345, Services: Customized packages.\n");
            break;
        case 4: // Thekkady
            printf("1. Thekkady Tours'n Travels, Contact: 789-012-3456, Services: Wildlife safaris.\n");
            printf("2. Periyar Adventures, Contact: 890-123-4567, Services: Eco-tours.\n");
            break;
        case 5: // Vagamon
            printf("1. Vagamon Tours, Contact: 901-234-5678, Services: Hill station tours.\n");
            printf("2. Vagamon Adventures, Contact: 012-345-6789, Services: Adventure activities.\n");
            break;
        case 6: // Kumarakom
            printf("1. Kumarakom Travels, Contact: 123-234-3456, Services: Backwater tours.\n");
            printf("2. Lakeside Travels, Contact: 234-345-4567, Services: Houseboat bookings.\n");
            break;
        case 7: // Wayanad
            printf("1. Wayanad Tours, Contact: 345-456-5678, Services: Nature tours.\n");
            printf("2. Wayanad Travels, Contact: 456-567-6789, Services: Trekking.\n");
            break;
        case 8: // Kovalam
            printf("1. Kovalam Travel Agency, Contact: 567-678-7890, Services: Beach packages.\n");
            printf("2. Oceanic Tours, Contact: 678-789-8901, Services: Coastal trips.\n");
            break;
        case 9: // Athirappilly
            printf("1. Athirappilly Tours, Contact: 789-890-9012, Services: Waterfall tours.\n");
            printf("2. Adventure Kerala, Contact: 890-901-0123, Services: Eco-tourism.\n");
            break;
        case 10: // Bekal
            printf("1. Bekal Travels, Contact: 901-012-1234, Services: Fort visits.\n");
            printf("2. Malabar Tours, Contact: 012-123-2345, Services: Beach tours.\n");
            break;
        default:
            printf("No travel agencies available for this location.\n");
            break;
    }
}