import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'AbpCoursesAcademmy',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44313/',
    redirectUri: baseUrl,
    clientId: 'AbpCoursesAcademmy_App',
    responseType: 'code',
    scope: 'offline_access AbpCoursesAcademmy',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44313',
      rootNamespace: 'AbpCoursesAcademmy',
    },
  },
} as Environment;
