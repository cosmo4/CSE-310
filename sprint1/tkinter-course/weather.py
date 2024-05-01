from tkinter import *
import requests
import json

root = Tk()
root.title('Weather App Tkinter')

# root.iconbitmap('path') for favicon
root.geometry("800x300")

# api_key = "9DF650B5-C018-43DF-A9B0-1EDF15BFD5D2"
green = "#00e400"
yellow = "#ffff00"
orange = "#ff7e00"
red = "#ff0000"
purple = "#8f3f97"
maroon = "#7e0023"

def zipLookup():
    # zip.get()
    # zipLabel = Label(root, text=zip.get())
    # zipLabel.grid(row=1, column=0, columnspan=2)

    try:
        api_request = requests.get(f"https://www.airnowapi.org/aq/forecast/zipCode/?format=application/json&zipCode={zip.get()}&date=2024-05-01&distance=25&API_KEY=9DF650B5-C018-43DF-A9B0-1EDF15BFD5D2")
        # api_request = requests.get("https://www.airnowapi.org/aq/forecast/zipCode/?format=application/json&zipCode=78023&date=2024-05-01&distance=25&API_KEY=9DF650B5-C018-43DF-A9B0-1EDF15BFD5D2")

        api = json.loads(api_request.content)

        city = api[0]['ReportingArea']
        quality = api[0]['AQI']
        category = api[0]['Category']['Name']

        if category == 'Good':
            weather_color = green
        elif category == 'Moderate':
            weather_color = yellow
        elif category == 'Unhealthy for Sensitive Groups':
            weather_color = orange
        elif category == 'Unhealthy':
            weather_color = red
        elif category == 'Very Unhealthy':
            weather_color = purple
        elif category == 'Hazardous':
            weather_color = maroon
        
        root.configure(background=weather_color)

        myLabel = Label(root, text=f"{city} Air Quality {quality} {category}", font=('Helvetica', 20), background=weather_color)

        myLabel.grid(row=1, column=0, columnspan=2)

    except Exception as e:
        api = "Error"

zip = Entry(root)
zip.grid(row=0, column=0)

zipButton = Button(root, text="Lookup Zipcode", command=zipLookup)
zipButton.grid(row=0, column=1)

root.mainloop()