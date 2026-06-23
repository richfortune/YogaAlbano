# YogaAlbano - Specifica MVP

## 1. Obiettivo
Realizzare una piattaforma web per la gestione di una scuola di yoga, composta da una landing page pubblica e da un'applicazione riservata a utenti registrati e amministratori.

## 2. Stack Tecnologico
- Backend: .NET 8 Web API
- Architettura: Clean Architecture
- Database: PostgreSQL
- ORM: Entity Framework Core
- Frontend App: React + TypeScript
- Sito pubblico: HTML/CSS
- Containerizzazione: Docker
- Versionamento e collaborazione: GitHub

## 3. Ambito MVP

### 3.1 Landing Page
Sezioni previste:
- Hero
- Chi siamo
- Corsi
- Insegnanti
- Orari
- Contatti
- Pulsante `Login / Registrati`

### 3.2 Registrazione Utente
Campi richiesti:
- Nome
- Cognome
- Email
- Password
- Privacy obbligatoria

Campi opzionali:
- Telefono

### 3.3 Flusso di Accesso
1. L'utente compila la registrazione.
2. Il sistema invia email di conferma.
3. Dopo la conferma email, l'account entra in stato `PendingApproval`.
4. Un Admin approva manualmente l'account.
5. Il login è consentito solo agli utenti approvati.

### 3.4 App Utente
Funzionalità principali:
- Visualizzazione lezioni disponibili
- Prenotazione lezioni
- Visualizzazione lista prenotazioni
- Cancellazione prenotazione fino a 2 ore prima dell'inizio lezione

### 3.5 Gestione Lezioni
Regole principali:
- Lezioni ricorrenti
- Massimo 15 partecipanti per lezione
- Lista d'attesa automatica oltre 15 iscritti
- Divieto di doppia prenotazione alla stessa lezione

### 3.6 Area Admin
Funzionalità principali:
- Gestione utenti
- Approvazione utenti
- Gestione corsi
- Gestione insegnanti
- Gestione lezioni
- Visualizzazione prenotazioni

## 4. Ruoli
- `Admin`
- `User`

## 5. Email di Sistema
Email previste nell'MVP:
- Conferma registrazione
- Approvazione account
- Recupero password
- Conferma prenotazione

## 6. Entità Principali
- `AppUser`
- `AdminUser`
- `Course`
- `Teacher`
- `RecurringClassSchedule`
- `YogaClass`
- `Booking`
- `RefreshToken`

## 7. Regole di Business
- Un utente non approvato non può effettuare login.
- La conferma email è obbligatoria prima dell'approvazione admin.
- Ogni lezione ha capacità massima di 15 partecipanti.
- Oltre la capacità massima, le prenotazioni entrano in lista d'attesa.
- Un utente non può prenotare due volte la stessa lezione.
- La cancellazione è consentita solo fino a 2 ore prima dell'inizio.
- In caso di disponibilità, la lista d'attesa deve poter avanzare automaticamente secondo ordine di richiesta.

## 8. Requisiti Funzionali Sintetici

### Pubblico
- Visualizzare contenuti informativi della scuola.
- Consentire accesso a registrazione e login.

### Utente
- Registrarsi e confermare l'email.
- Accedere solo dopo approvazione admin.
- Consultare lezioni disponibili.
- Prenotare e cancellare prenotazioni entro i limiti previsti.

### Admin
- Approvare utenti registrati.
- Gestire catalogo corsi, insegnanti e lezioni.
- Monitorare prenotazioni e lista d'attesa.

## 9. Requisiti Non Funzionali
- API REST sviluppata in .NET 8.
- Separazione chiara dei layer secondo Clean Architecture.
- Persistenza su PostgreSQL tramite Entity Framework Core.
- Frontend web separato dal backend.
- Ambiente avviabile tramite Docker.
- Repository gestito su GitHub.
