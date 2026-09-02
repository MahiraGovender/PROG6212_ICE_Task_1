# PROG6212_ICE_Task_1

## Endpoint Specification Table

| Resource or Feature | Endpoint URL            | HTTP Method | Purpose / Description                                              | Request Body / Parameters                                                                    | Expected Response and Status Code                                                                                             |
| ------------------- | ----------------------- | ----------- | ------------------------------------------------------------------ | -------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------- |
| Games               | `/api/gameswebapi`      | **GET**     | Retrieves all game records stored in the Game Achievement Tracker. | None                                                                                         | **200 OK** – Returns a list of game records.                                                                                  |
| Game by ID          | `/api/gameswebapi/{id}` | **GET**     | Retrieves a specific game record using its unique ID.              | `id` – Game ID in the URL.                                                                   | **200 OK** – Returns the requested game. **404 Not Found** – Game does not exist.                                             |
| Games               | `/api/gameswebapi`      | **POST**    | Creates a new game record in the Game Achievement Tracker.         | `gameName`, `genre`, `hoursPlayed`, `achievementsEarned`, `totalAchievements`, `isCompleted` | **201 Created** – Game successfully created. **400 Bad Request** – Invalid data supplied.                                     |
| Game by ID          | `/api/gameswebapi/{id}` | **PUT**     | Updates an existing game record using its unique ID.               | `id` – Game ID in the URL. Request body contains updated game information.                   | **200 OK** – Game successfully updated. **400 Bad Request** – Invalid data supplied. **404 Not Found** – Game does not exist. |
| Game by ID          | `/api/gameswebapi/{id}` | **DELETE**  | Deletes an existing game record using its unique ID.               | `id` – Game ID in the URL.                                                                   | **204 No Content** – Game successfully deleted. **404 Not Found** – Game does not exist.                                      |


## Youtube Video Presentation
[Presentation video](https://youtu.be/lejzx_ee89k)
