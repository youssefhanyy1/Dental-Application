# Dental Application UI

A Windows Forms UI prototype for a dental-clinic application, written in C# for .NET Framework 4.7.2.

## Included screens

- Login and loading screens.
- Main navigation and dashboard.
- Patient list populated with sample data.
- Calendar view with demonstration events.

The interface uses Guna.UI2.WinForms 2.0.4.7 and Guna.Charts.WinForms 1.1.0.0, as listed in `packages.config`.

## Open locally

1. Use Windows and Visual Studio with .NET desktop development and the .NET Framework 4.7.2 targeting pack.
2. Open `Dental Application/Dental Application.csproj`.
3. Restore the NuGet packages and check their licensing terms for your intended use.
4. Review image references before running. The sample patient-list code loads images from relative `photos` paths that are not supplied as a complete runtime dataset in this repository.

## Prototype status

This is an interface exercise, not a complete clinic-management system. The login screen does not validate credentials, and patient/calendar views use demonstration data. A database-backed patient system and real authentication are not implemented in the reviewed source.

Build and runtime behavior have not been verified as part of this documentation update. Do not use real patient data.
