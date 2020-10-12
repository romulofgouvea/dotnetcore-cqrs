import { InjectionToken } from '@angular/core';

export let APP_CONFIG = new InjectionToken('app.config');

export interface IAppConfig {
  base_url: string;
}

export const AppConfig: IAppConfig = {
  base_url: 'http://localhost:3333'
};
