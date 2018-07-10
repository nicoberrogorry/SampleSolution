import { Component } from '@angular/core';
import { MenuSection } from './menuSection';

@Component({
  selector: 'navigator',
  templateUrl: './navigator.html',
  styleUrls: ['./navigator.scss']
})

export class Navigator {
  private sections : MenuSection[];

  constructor(){
    this.sections = [
      {title: 'First Sample Solution', pages: null },
      {title: 'Administration', pages: [
        {title: 'Persons', items: [
          {title: 'Persons Grid', destination: '/Administration/PersonsGrid'},
          {title: 'Create Person', destination: '/Administration/CreatePerson'}
        ]},
        {title: 'Professions', items: [
          {title: 'Professions Grid', destination: '/Administration/ProfessionsGrid'},
          {title: 'Create Profession', destination: '/Administration/CreateProfession'}
        ]}
      ]}
    ];
  }
}